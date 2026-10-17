:: ============================================================================
:: BUILD GLOBAL - VISUAL STUDIO 2022
:: VERSION COMENTADA PARA REUTILIZAR EN OTROS PROYECTOS
:: ============================================================================
::
:: QUE HACE ESTE SCRIPT:
:: 1. Usa MSBuild de Visual Studio 2022 para compilar proyectos C#.
:: 2. Compila primero los componentes base: Reporteador, Consultas, Seguridad
::    y Navegador.
:: 3. Busca automaticamente todos los archivos .sln dentro de BASE_DIR.
:: 4. Compila cada solucion en configuracion Debug.
:: 5. Guarda los resultados en la carpeta logs.
:: 6. Verifica que existan determinadas DLL de los componentes base.
::
:: PARA USARLO CON OTRO PROYECTO, NORMALMENTE SOLO DEBES CAMBIAR:
::
::   MSBUILD_PATH   -> Si tu Visual Studio 2022 no es Community o esta en otra ruta.
::   COMPONENTES_DIR -> Carpeta donde estan tus componentes compartidos/base.
::   BASE_DIR       -> Carpeta principal del equipo o proyecto que quieres compilar.
::
:: Ejemplo para Equipo 3:
::   set "BASE_DIR=C:\is2k26pf\codigo\empresarial\Equipo 3"
::
:: Si el otro proyecto utiliza COMPONENTES diferentes, tambien debes modificar
:: las rutas de los .csproj dentro de la funcion :CompilarModulo y las DLL que se
:: verifican mas abajo.
::
:: IMPORTANTE:
:: Las rutas que contienen espacios siempre deben ir entre comillas.
:: ============================================================================

:INICIO
@echo off
setlocal enabledelayedexpansion
color 0A

echo ============================================
echo COMPILACION COMPLETA GLOBAL - VISUAL 2022
echo ============================================

:: --------------------------------------------------------------------------
:: 1) RUTA DE MSBUILD DE VISUAL STUDIO 2022
:: --------------------------------------------------------------------------
:: Esta ruta corresponde a Visual Studio 2022 Community.
:: Si tienes Professional, normalmente cambia "Community" por "Professional".
:: Si tienes Enterprise, cambia "Community" por "Enterprise".
::
:: Ejemplo Professional:
:: C:\Program Files\Microsoft Visual Studio2\Professional\MSBuild\Current\Bin\MSBuild.exe
:: --------------------------------------------------------------------------
set "MSBUILD_PATH=C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe"

:: --------------------------------------------------------------------------
:: 2) CARPETA DE COMPONENTES BASE
:: --------------------------------------------------------------------------
:: Aqui deben estar los componentes compartidos por los proyectos, por ejemplo:
:: navegador, seguridad, reporteador, consultas, etc.
::
:: CAMBIA ESTA RUTA si en otro proyecto los componentes estan en otra ubicacion.
:: --------------------------------------------------------------------------
set "COMPONENTES_DIR=C:\proyectoasis22k26-Seguridad\codigo\componentes"

:: --------------------------------------------------------------------------
:: 3) CARPETA PRINCIPAL DEL PROYECTO / EQUIPO
:: --------------------------------------------------------------------------
:: ESTA ES LA RUTA QUE MAS PROBABLEMENTE CAMBIARAS.
:: El script recorrera esta carpeta y todas sus subcarpetas buscando archivos .sln.
::
:: Ejemplos:
::   Equipo 3:
::   set "BASE_DIR=C:\is2k26pf\codigo\empresarial\Equipo 3"
::
::   Otro proyecto:
::   set "BASE_DIR=D:\Proyectos\SistemaVentas"
:: --------------------------------------------------------------------------
set "BASE_DIR=C:\proyectoasis22k26-Seguridad\codigo\componentes\seguridad"

:: --------------------------------------------------------------------------
:: 4) CARPETA DONDE ESTA GUARDADO ESTE ARCHIVO .BAT
:: --------------------------------------------------------------------------
:: %~dp0 obtiene automaticamente la carpeta del propio .bat.
:: Normalmente NO tienes que modificar esta linea.
:: --------------------------------------------------------------------------
set "ROOT_DIR=%~dp0"

cd /d "%ROOT_DIR%"
if not exist "logs" mkdir logs

:: ==========================================================
:: CICLOS DE COMPILACION BASE
:: ==========================================================
for /L %%i in (1,1,2) do (
    echo.
    echo ============================================
    echo CICLO %%i DE COMPILACION BASE
    echo ============================================

    call :CompilarModulo NAVEGADOR || echo Error en NAVEGADOR ciclo %%i
    call :CompilarModulo SEGURIDAD || echo Error en SEGURIDAD ciclo %%i
)

echo.
echo ============================================
echo CICLOS BASE FINALIZADOS
echo ============================================


:: ==========================================================
:: COPIAR DLLs BASE (Debug -> Release)
:: ==========================================================
echo.
echo ============================================
echo COPIANDO DLLs BASE DE DEBUG A RELEASE
echo ============================================

for /r "%COMPONENTES_DIR%" %%d in (*.dll) do (
    if exist "%%d" (
        if not exist "%%~dpd..\Release" mkdir "%%~dpd..\Release"
        copy /Y "%%d" "%%~dpd..\Release\" >nul
    )
)

echo DLLs base copiadas correctamente.


:: ==========================================================
:: COMPILAR TODOS LOS PROYECTOS .SLN EN EQUIPO 2
:: ==========================================================
echo.
echo ============================================
echo BUSCANDO Y COMPILANDO PROYECTOS .SLN EN EQUIPO 2 (DEBUG)
echo ============================================

set /a total=0
set /a ok=0
set /a fail=0

:: "for /r" recorre BASE_DIR y todas sus subcarpetas.
:: Cada archivo .sln encontrado se guarda temporalmente en %%f.
:: Gracias a esto NO tienes que escribir manualmente cada solucion.
for /r "%BASE_DIR%" %%f in (*.sln) do (
    set /a total+=1
    echo -------------------------------------------
    echo Compilando: %%f
    echo -------------------------------------------
    :: Compila la solucion encontrada:
    :: /p:Configuration=Debug -> usa configuracion Debug.
    :: /m                     -> permite compilacion en paralelo.
    :: /verbosity:minimal     -> muestra menos texto en consola.
    :: >> archivo 2>&1        -> guarda salida normal y errores en el log.
    "%MSBUILD_PATH%" "%%f" /p:Configuration=Debug /m /verbosity:minimal >> "logs\build_all_log.txt" 2>&1

    if !errorlevel! == 0 (
        echo Compilado correctamente: %%f
        echo [OK] %%f >> "logs\build_all_log.txt"
        set /a ok+=1
    ) else (
        echo Error al compilar: %%f
        echo [ERROR] %%f >> "logs\build_all_log.txt"
        set /a fail+=1
    )
)

echo.
echo ============================================
echo COMPILACION GLOBAL FINALIZADA
echo Total proyectos: %total%
echo Correctos: %ok%
echo Errores: %fail%
echo Logs en: logs\build_all_log.txt
echo ============================================


:: ==========================================================
:: VERIFICAR DLLs DE COMPONENTES BASE
:: ==========================================================
echo.
echo ============================================
echo VERIFICANDO DLLs DE COMPONENTES BASE
echo ============================================

set "dlls="
set "dlls=%dlls% %COMPONENTES_DIR%\navegador\Navegador\CapaControlador_Navegador\bin\Debug\CapaControlador_Navegador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\navegador\Navegador\CapaModelo_Navegador\bin\Debug\CapaModelo_Navegador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\navegador\Navegador\CapaVista_Navegador\bin\Debug\CapaVista_Navegador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\seguridad\Seguridad\CapaControlador_Seguridad\bin\Debug\CapaControlador_Seguridad.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\seguridad\Seguridad\CapaModelo_Seguridad\bin\Debug\CapaModelo_Seguridad.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\seguridad\Seguridad\CapaVista_Seguridad\bin\Debug\CapaVista_Seguridad.dll"

for %%d in (%dlls%) do (
    if exist "%%d" (
        echo [OK] %%d
    ) else (
        echo [FALTA] %%d
    )
)

echo.
echo ============================================
echo VERIFICANDO DLLs DE CONSULTAS
echo ============================================


if exist "%COMPONENTES_DIR%\navegador\Navegador\CapaControlador_Navegador\bin\Debug\CapaControlador_Navegador.dll" (
    echo [OK] CapaControlador_Navegador - Capa Controlador
) else (
    echo [FALTA] CapaControlador_Navegador - Capa Controlador
)

if exist "%COMPONENTES_DIR%\navegador\Navegador\CapaModelo_Navegador\bin\Debug\CapaModelo_Navegador.dll" (
    echo [OK] CapaModelo_Navegador - Capa Modelo
) else (
    echo [FALTA] CapaModelo_Navegador - Capa Modelo
)

if exist "%COMPONENTES_DIR%\navegador\Navegador\CapaVista_Navegador\bin\Debug\CapaVista_Navegador.dll" (
    echo [OK] CapaVista_Navegador - Capa Vista
) else (
    echo [FALTA] CapaVista_Navegador - Capa Vista
)

if exist "%COMPONENTES_DIR%\seguridad\Seguridad\CapaControlador_Seguridad\bin\Debug\CapaControlador_Seguridad.dll" (
    echo [OK] CapaControlador_Seguridad - Capa Controlador
) else (
    echo [FALTA] CapaControlador_Seguridad - Capa Controlador
)

if exist "%COMPONENTES_DIR%\seguridad\Seguridad\CapaModelo_Seguridad\bin\Debug\CapaModelo_Seguridad.dll" (
    echo [OK] CapaModelo_Seguridad - Capa Modelo
) else (
    echo [FALTA] CapaModelo_Seguridad - Capa Modelo
)

if exist "%COMPONENTES_DIR%\seguridad\Seguridad\CapaVista_Seguridad\bin\Debug\CapaVista_Seguridad.dll" (
    echo [OK] CapaVista_Seguridad - Capa Vista
) else (
    echo [FALTA] CapaVista_Seguridad - Capa Vista
)

echo.
echo ============================================
echo COMPILACION FINALIZADA COMPLETAMENTE
echo ============================================
echo.
echo ============================================
echo Presiona una opcion:
echo [R] Recompilar
echo [S] Salir
echo ============================================

choice /c RS /n /m "Seleccion: "

if errorlevel 2 goto FIN
if errorlevel 1 goto INICIO

:FIN
exit /b 0
exit /b 0


:: ==========================================================
:: FUNCION: COMPILAR MODULOS BASE
:: ==========================================================
:: Esta funcion recibe el nombre del modulo en %1.
:: Ejemplo:
::     call :CompilarModulo SEGURIDAD
::
:: Si reutilizas este script en un proyecto que NO tiene estos mismos componentes,
:: puedes cambiar o eliminar los bloques REPORTEADOR, CONSULTAS, SEGURIDAD y
:: NAVEGADOR, y agregar tus propios .csproj.
:: ==========================================================
:CompilarModulo
echo ============================================
echo COMPILANDO MODULO: %1
echo ============================================

if /I "%1"=="NAVEGADOR" (
    for %%p in ("%COMPONENTES_DIR%\navegador\Navegador\CapaModelo_Navegador\*.csproj") do call :CompilarProyecto "%%~fp" || exit /b 1
    for %%p in ("%COMPONENTES_DIR%\navegador\Navegador\CapaControlador_Navegador\*.csproj") do call :CompilarProyecto "%%~fp" || exit /b 1
    for %%p in ("%COMPONENTES_DIR%\navegador\Navegador\CapaVista_Navegador\*.csproj") do call :CompilarProyecto "%%~fp" || exit /b 1
)

if /I "%1"=="SEGURIDAD" (
    for %%p in ("%COMPONENTES_DIR%\seguridad\Seguridad\CapaModelo_Seguridad\*.csproj") do call :CompilarProyecto "%%~fp" || exit /b 1
    for %%p in ("%COMPONENTES_DIR%\seguridad\Seguridad\CapaControlador_Seguridad\*.csproj") do call :CompilarProyecto "%%~fp" || exit /b 1
    for %%p in ("%COMPONENTES_DIR%\seguridad\Seguridad\CapaVista_Seguridad\*.csproj") do call :CompilarProyecto "%%~fp" || exit /b 1
)

exit /b 0

:: ==========================================================
:: FUNCION: COMPILAR UN .CSPROJ (devuelve el codigo de MSBuild)
:: ==========================================================
:CompilarProyecto
echo   -^> %~nx1
"%MSBUILD_PATH%" "%~1" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
exit /b %errorlevel%