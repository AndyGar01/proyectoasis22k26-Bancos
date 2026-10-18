# CapaControlador_Contabilidad

Proyecto de biblioteca de clases .NET Framework 4.8.

- `ClsControladorLoginContabilidad` valida usuario y contraseña (hash BCrypt) con el Modelo
  y abre la sesión.
- `ClsSesionContabilidad` guarda usuario, empleado y roles. Refleja los datos en
  `ClsSesionSeguridad` solo porque el Navegador (DLL compartida) la lee.
- `ClsControladorSeguridadContabilidad` resuelve los IDs reales de las aplicaciones por
  nombre y consulta el acceso de los roles del usuario (`ClsEstadoSeguridadContabilidad`).
- `ClsControladorPolizasContabilidad` y `ClsLineaPolizaContabilidad`: período contable,
  totales del debe y del haber, cuadre y validación de una póliza. Importes en `decimal`.
