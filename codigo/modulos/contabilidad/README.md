# Contabilidad

Módulo Windows Forms .NET Framework 4.8 con tres capas MVC (Modelo, Controlador, Vista) y
referencias DLL. Es un **prototipo no funcional**: las pantallas se diseñan sobre la
estructura del esquema `dbContabilidad` pero usan datos de ejemplo y no escriben en la base.

## Ejecutar

1. Compilar las dependencias (Consultas, Seguridad Modelo/Controlador y Navegador) con
   `codigo/componentes/navegador/build_navegador.bat`.
2. Ejecutar `codigo/modulos/contabilidad/build_contabilidad.bat`.
3. Abrir `codigo/modulos/contabilidad/Ejecucion_Contabilidad/Ejecucion_Contabilidad/bin/Debug/Ejecucion_Contabilidad.exe`.
4. Iniciar sesión con un usuario de la base compartida: Login → Splash → MDI.
   Al cerrar el MDI se cierra la sesión y se vuelve al login.

El módulo tiene su propio login, pantalla de carga y conexión ODBC (DSN `EmbutidosS.A`).
La contraseña se verifica contra el hash BCrypt de `tblusuario`. Contabilidad es x64.

## Permisos

Los botones del menú se habilitan según los roles del usuario en `tblrolmoduloaplicacion`.
En la base local se registraron las cinco pantallas en el módulo `Contabilidad` (ID 17),
con IDs físicos 28–32, el 14/10/2026. La aplicación general existente (ID 27) se conserva.
Por petición de Gabriel, las cinco pantallas están asignadas únicamente al rol Administrador
(ID 1), con permisos de insertar, editar, eliminar e imprimir. Los demás roles no tienen
asignaciones a estas cinco pantallas. El acceso general existente no se modificó.
En otras instalaciones hay que crear el módulo y sus cinco aplicaciones con estos nombres exactos (el módulo las busca por
nombre) y asignarlas a los roles: `Pólizas locales`, `Presupuestos`, `Activos fijos`,
`Cierre contable` y `Estados financieros`. Códigos de ventana: 10001 a 10005.

`scripts/modulos/contabilidad/RegistrarAplicacionesContabilidad.ps1 -Aplicar` registra o
reactiva esas aplicaciones mediante el DSN existente y una transacción; conserva otros accesos
y no cambia permisos. Sin `-Aplicar` consulta y verifica el registro. Los IDs físicos se generan
en la base y pueden diferir entre instalaciones.

`scripts/modulos/contabilidad/AsignarAdministradorContabilidad.ps1` reproduce la asignación
de las cinco pantallas al Administrador activo mediante una transacción. Verifica exclusividad
sin modificar otros roles; si encuentra asignaciones a otros roles, revierte su transacción.

## Base de datos

`scripts/modulos/contabilidad/dbContabilidad.sql` define el esquema nuevo según EST-01 V1.2
(`tblPais`, `tblModulo`, `tblCuenta`, `tblModuloCuenta`, `tblPolizaEncabezado`, `tblPolizaDetalle`,
`tblPresupuestoEncabezado`, `tblPresupuestoDetalle`, `tblMaestroVidaUtil`, `tblActivoFijo`).
**Todavía no se ejecuta ni se usa desde el código.** Usa `CREATE ... IF NOT EXISTS` y no borra
nada. Las tablas `tblconta*` anteriores ya no existen.

## Estado de las pantallas

- **Pólizas locales**: prototipo con encabezado, cuentas desplegables, debe/haber y totales.
- **Presupuestos**: fechas, partidas por módulo, total/gastado/restante y validación de ejemplo.
  Se pueden agregar y quitar partidas en memoria; Nuevo limpia y Restablecer recupera la muestra.
- **Activos fijos**: ficha, maestro de vida útil y cálculo de depreciación mensual por línea recta.
  Valida fechas, valor residual y vida útil; no registra activos ni genera pólizas.
- **Cierre contable**: revisión de pólizas por período, totales aplicados y diagnóstico.
  Octubre de 2026 contiene un borrador que bloquea la simulación; septiembre permite simular.
  No genera asientos ni cierra períodos en la base.
- **Estados financieros**: estado de resultados de solo lectura con rango de fechas; incluye solo
  pólizas aplicadas. La muestra de octubre presenta ingresos Q 120,000.00, costos Q 65,000.00,
  gastos Q 18,000.00 y resultado Q 37,000.00. La clase contable se deriva de códigos
  `C.GG.CC.SSS` del catálogo de muestra; el catálogo real y su persistencia siguen pendientes.

Cada pantalla usa su controlador (`ClsControladorPolizas`, `Presupuestos`, `ActivosFijos`, `Cierre` y
`EstadosFinancieros`, todos con sufijo `Contabilidad`), que valida con DataAnnotations y llama a su repositorio en
memoria. Los botones Guardar llaman a `ContabilidadFuncGrabarCambios`; Cerrar período solo valida.
La interfaz omite avisos de prototipo y referencias a datos de ejemplo por decisión de presentación;
esto no cambia el alcance técnico ni agrega persistencia.

## Verificación de prototipos

Después de compilar las capas, ejecutar desde la raíz con Windows PowerShell x64:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -STA -File scripts/modulos/contabilidad/VerificarPrototiposContabilidad.ps1
```

El parámetro de ejecución solo se aplica a ese proceso. El script comprueba cálculos, fechas,
filtros, estados vacíos e interacciones en memoria, sin iniciar sesión ni acceder a MySQL.
Genera capturas PNG en `manuales/modulos/contabilidad/capturas-prototipos` (carpeta ignorada),
o en la ruta indicada mediante `-Salida`. El login real y los permisos requieren una prueba aparte.

## Estandarización EST-10 V1.1

Se aplicaron códigos de ventana 10001–10005 y nombres PascalCase, etiquetas Tahoma,
títulos Lucida Fax en negrita/cursiva, campos Segoe UI, validación con asterisco/borde/error
por campo, diálogos estándar y botones Guardar deshabilitados antes de cambios.
Los listados tienen páginas de 10 registros, total y ordenación global por columna.
Las ventanas secundarias caben en un área útil de 1366×728 y conservan el comportamiento modal.

El catálogo de muestra comparte códigos únicos `C.GG.CC.SSS`; el Controlador valida el formato
y deriva las clases Activo/Pasivo/Patrimonio/Ingresos/Costos/Gastos. No se migró la base:
antes de persistir cuentas hay que añadir código al esquema y completar las reglas de cuentas
con movimientos. El login propio se conserva por instrucción previa; difiere del flujo de
Seguridad descrito en la norma. La ayuda CHM y la exportación RDLC todavía no están implementadas.
Se conservaron los recursos gráficos existentes; no se contrastaron con Teams.

`scripts/modulos/contabilidad/VerificarEstandarizacionContabilidad.ps1` comprueba estas reglas
y genera capturas. La matriz detallada local está en
`manuales/modulos/contabilidad/ESTANDARIZACION_V1_1.md` (carpeta ignorada por Git).

## Arquitectura MVC (capacitación y EST-10)

- **CapaModelo_Contabilidad**: única capa con ODBC y SQL. `Repositorios/` (`ClsRepositorioContabilidad` conecta,
  `ClsRepositorioMaestroContabilidad` ejecuta sentencias, los demás heredan o implementan contratos),
  `Contratos/` (`IRepositorioGenericoContabilidad<T>` y una interfaz por repositorio) y `Entidades/` (una clase por tabla).
  Los repositorios de pólizas, presupuestos y activos trabajan en memoria; al pasar a MySQL solo cambian ellos.
- **CapaControlador_Contabilidad**: `Modelos/` con las validaciones (DataAnnotations e `IValidatableObject`),
  `Validacion/` (`EstadoEntidadContabilidad`, límites y el validador común) y un controlador por pantalla.
- **CapaVista_Contabilidad**: formularios y controles; solo referencia al Controlador.
- **Ejecucion_Contabilidad**: aplicación Windows Forms que referencia únicamente la Vista.

Orden de compilación y de referencias: Modelo → Controlador → Vista → Ejecución (hasta ver "actualizados").

## Estructura

- `Contabilidad/CapaVista_Contabilidad/Componentes`: controles reutilizables (botón, tabla y
  panel redondeado con la paleta del módulo) y sus íconos en `Resources`.
- `scripts/modulos/contabilidad/GenerarRecursosContabilidad.ps1` y
  `GenerarIconosContabilidad.py` regeneran las imágenes a partir de `recursos/modulos/contabilidad`.

La única dependencia técnica con Seguridad es que el Navegador (DLL compartida) lee la sesión
desde `ClsSesionSeguridad`; `ClsSesionContabilidad` la refleja al iniciar y cerrar sesión.
