# CapaModelo_Contabilidad

Proyecto de biblioteca de clases .NET Framework 4.8 con su propia conexión ODBC
(`ClsConexionContabilidad`, DSN `EmbutidosS.A`) y ejecución de sentencias
(`ClsSentenciasContabilidad`); no depende de CapaModelo_Seguridad.

- `ClsRepositorioUsuariosContabilidad`: usuario activo y roles para el login (lecturas).
- `ClsRepositorioSeguridadContabilidad`: aplicaciones del módulo y permisos por rol (lecturas).
- `ClsRepositorioPolizasContabilidad` y `ClsCuentaContabilidad`: catálogos de EJEMPLO con la
  forma de `presupuesto_db` (cuenta, estados y orígenes de póliza). No consulta la base; cuando
  el prototipo pase a datos reales solo este repositorio cambia.
