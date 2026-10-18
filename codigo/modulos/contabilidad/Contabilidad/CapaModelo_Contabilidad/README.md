# CapaModelo_Contabilidad

Proyecto de biblioteca de clases .NET Framework 4.8 con su propia conexión ODBC
(`ClsRepositorioContabilidad`, DSN `EmbutidosS.A`) y ejecución de sentencias
(`ClsRepositorioMaestroContabilidad`); no depende de CapaModelo_Seguridad.

Carpetas: `Repositorios`, `Contratos` (interfaces) y `Entidades` (una clase por tabla).

- `ClsRepositorioUsuariosContabilidad`: usuario activo y roles para el login (lecturas).
- `ClsRepositorioSeguridadContabilidad`: aplicaciones del módulo y permisos por rol (lecturas).
- `ClsRepositorioPolizasContabilidad`, `ClsRepositorioPresupuestosContabilidad` y
  `ClsRepositorioActivosFijosContabilidad`: implementan sus contratos en memoria con datos de EJEMPLO
  que tienen la forma de `dbContabilidad`. No consultan la base; al pasar a datos reales solo cambian ellos.
