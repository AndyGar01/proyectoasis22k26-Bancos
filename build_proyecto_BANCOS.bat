@echo off
setlocal EnableExtensions DisableDelayedExpansion
:: Punto unico de compilacion. Guardar en la raiz del repositorio.
:: Uso: build_proyecto.bat [/auto]
:: /auto evita el menu y devuelve 1 si algun proyecto no compilo.
:: MSBUILD_MANUAL permite indicar una instalacion alternativa de MSBuild.exe.
set "AUTO=0"
if /i "%~1"=="/auto" set "AUTO=1"
set "ROOT=%~dp0"
set "COMP=%ROOT%codigo\componentes"
set "BANCOS=%ROOT%codigo\modulos\bancos"
set "LOG_DIR=%ROOT%logs\build_proyecto"
set "LOG=%LOG_DIR%\build_log.txt"
set "FAILED=%LOG_DIR%\fallidos.txt"
if not exist "%LOG_DIR%\" mkdir "%LOG_DIR%"
if not exist "%LOG_DIR%\" goto ERROR_INICIO
if not exist "%COMP%\" goto ERROR_INICIO
if not exist "%BANCOS%\" goto ERROR_INICIO

:INICIO
> "%LOG%" echo Compilacion global - %DATE% %TIME%
if errorlevel 1 goto ERROR_INICIO
call :DetectarMSBuild
if errorlevel 1 goto ERROR_INICIO
echo MSBuild: "%MSBUILD_PATH%"
>> "%LOG%" echo MSBuild: "%MSBUILD_PATH%"
set "RONDA=0"

:RONDA
set /a RONDA+=1 >nul
set /a TOTAL=0, OK=0, FAIL=0 >nul
type nul > "%FAILED%"
echo.
echo ===== COMPILACION GLOBAL - RONDA %RONDA% DE 3 =====
>> "%LOG%" echo ===== RONDA %RONDA% =====
:: Seguridad base precede a Navegador; Seguridad vista necesita Bancos vista.
:: Consultas y Reporteador tienen dependencias internas entre sus submodulos.
:: Los reintentos permiten resolver referencias a DLL entre esos proyectos.
for %%C in (seguridad consultas navegador reporteador) do call :Capas "%COMP%\%%C" BASE
call :Capas "%BANCOS%" BASE
for %%C in (consultas navegador reporteador) do call :Capas "%COMP%\%%C" VISTA
for /d %%D in ("%BANCOS%\*") do if /i not "%%~nxD"=="Bancos" call :Capas "%%~fD" VISTA
call :Capas "%BANCOS%\Bancos" VISTA
call :Capas "%COMP%\seguridad" VISTA
:: Todos los ejecutables se compilan al final, incluido Ejecucion_Bancos.
for %%C in (consultas navegador reporteador seguridad) do call :Ejecutables "%COMP%\%%C"
call :Ejecutables "%BANCOS%"
if %FAIL% EQU 0 goto RESUMEN
if %RONDA% LSS 3 goto RONDA

:RESUMEN
set "EXIT_CODE=0"
if %FAIL% GTR 0 set "EXIT_CODE=1"
if %TOTAL% EQU 0 set "EXIT_CODE=1"
echo.
echo ===== RESUMEN DE LA ULTIMA RONDA =====
echo Total: %TOTAL% - Correctos: %OK% - Errores: %FAIL%
echo Log: "%LOG%"
>> "%LOG%" echo Total: %TOTAL% - Correctos: %OK% - Errores: %FAIL%
if %FAIL% GTR 0 type "%FAILED%"
if "%EXIT_CODE%"=="0" echo [OK] Compilacion completa.
if not "%EXIT_CODE%"=="0" echo [ERROR] La compilacion no se completo correctamente.
if "%AUTO%"=="1" goto FIN

:MENU
echo.
choice /c RVS /n /m "[R] Recompilar  [V] Ver log  [S] Salir: "
if errorlevel 3 goto FIN
if errorlevel 2 (
    start "" notepad.exe "%LOG%"
    goto MENU
)
if errorlevel 1 goto INICIO
goto MENU

:FIN
endlocal & exit /b %EXIT_CODE%

:ERROR_INICIO
echo [ERROR] No se pudo iniciar la compilacion.
echo Comprueba las carpetas del repositorio y Visual Studio con desarrollo de escritorio .NET.
echo Log: "%LOG%"
if "%AUTO%"=="0" pause
endlocal & exit /b 1

:DetectarMSBuild
set "MSBUILD_PATH="
if defined MSBUILD_MANUAL (
    if not exist "%MSBUILD_MANUAL%" exit /b 1
    set "MSBUILD_PATH=%MSBUILD_MANUAL%"
    exit /b 0
)
set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
if exist "%VSWHERE%" (
    "%VSWHERE%" -latest -products * -requires Microsoft.Component.MSBuild -find MSBuild\Current\Bin\MSBuild.exe > "%LOG_DIR%\msbuild.txt" 2>> "%LOG%"
    for /f "usebackq delims=" %%M in ("%LOG_DIR%\msbuild.txt") do if not defined MSBUILD_PATH set "MSBUILD_PATH=%%M"
)
if defined MSBUILD_PATH if exist "%MSBUILD_PATH%" exit /b 0
set "MSBUILD_PATH="
for %%V in (2022 2019) do for %%E in (Community Professional Enterprise BuildTools) do (
    if not defined MSBUILD_PATH if exist "%ProgramFiles%\Microsoft Visual Studio\%%V\%%E\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD_PATH=%ProgramFiles%\Microsoft Visual Studio\%%V\%%E\MSBuild\Current\Bin\MSBuild.exe"
    if not defined MSBUILD_PATH if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\%%V\%%E\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD_PATH=%ProgramFiles(x86)%\Microsoft Visual Studio\%%V\%%E\MSBuild\Current\Bin\MSBuild.exe"
)
if defined MSBUILD_PATH exit /b 0
exit /b 1

:Capas
if not exist "%~1\" (
    echo [ERROR] No existe "%~1"
    >> "%FAILED%" echo Carpeta ausente: "%~1"
    set /a FAIL+=1 >nul
    exit /b 1
)
if /i "%~2"=="VISTA" (
    for /r "%~1" %%P in (CapaVista_*.csproj) do call :Build "%%~fP"
    exit /b 0
)
for %%C in (CapaModelo_ CapaControlador_) do for /r "%~1" %%P in (%%C*.csproj) do call :Build "%%~fP"
for /r "%~1" %%P in (*.csproj) do call :NoCapa "%%~fP" LIB
exit /b 0

:Ejecutables
for /r "%~1" %%P in (*.csproj) do call :NoCapa "%%~fP" EXE
exit /b 0

:NoCapa
echo "%~nx1" | findstr /i /c:"CapaModelo_" /c:"CapaControlador_" /c:"CapaVista_" >nul
if not errorlevel 1 exit /b 0
findstr /i /c:"<OutputType>Library</OutputType>" "%~1" >nul
if errorlevel 1 (
    if "%~2"=="LIB" exit /b 0
) else (
    if "%~2"=="EXE" exit /b 0
)
call :Build "%~1"
exit /b %ERRORLEVEL%

:Build
echo "%~1" | findstr /i /l /c:"\packages\" /c:"\obj\" /c:"\bin\" >nul
if not errorlevel 1 exit /b 0
set /a TOTAL+=1 >nul
set "STEP_LOG=%LOG_DIR%\ronda_%RONDA%_paso_%TOTAL%_%~n1.log"
echo [%TOTAL%] %~n1
:: Buscar la solucion mas cercana para restaurar packages.config.
set "SOLUTION_DIR=%~dp1"
call :BuscarSolucion
if errorlevel 1 goto BUILD_ERROR
"%MSBUILD_PATH%" "%~1" /nologo /restore /p:RestorePackagesConfig=true /p:SolutionDir="%SOLUTION_DIR%\" /t:Rebuild /p:Configuration=Debug /v:minimal > "%STEP_LOG%" 2>&1
set "BUILD_RC=%ERRORLEVEL%"
>> "%LOG%" echo ----- "%~1"
type "%STEP_LOG%" >> "%LOG%"
if not "%BUILD_RC%"=="0" goto BUILD_ERROR
:: Compatibilidad con referencias existentes a bin\Release.
:: Son DLL Debug, no una compilacion Release.
if exist "%~dp1bin\Debug\*.dll" (
    if not exist "%~dp1bin\Release\" mkdir "%~dp1bin\Release"
    copy /y "%~dp1bin\Debug\*.dll" "%~dp1bin\Release\" >nul 2>&1
    if errorlevel 1 goto BUILD_ERROR
)
set /a OK+=1 >nul
echo [OK] %~n1
exit /b 0

:BUILD_ERROR
set /a FAIL+=1 >nul
echo [ERROR] %~n1 - revisar "%STEP_LOG%"
>> "%FAILED%" echo "%~1"
>> "%LOG%" echo [ERROR] "%~1"
if exist "%STEP_LOG%" findstr /i /c:": error " /c:"error MSB" /c:"error NU" "%STEP_LOG%"
exit /b 1

:BuscarSolucion
if exist "%SOLUTION_DIR%*.sln" exit /b 0
for %%D in ("%SOLUTION_DIR%..") do set "PARENT_DIR=%%~fD\"
if /i "%PARENT_DIR%"=="%SOLUTION_DIR%" (
    echo [ERROR] No se encontro una solucion para el proyecto.
    exit /b 1
)
set "SOLUTION_DIR=%PARENT_DIR%"
goto BuscarSolucion
