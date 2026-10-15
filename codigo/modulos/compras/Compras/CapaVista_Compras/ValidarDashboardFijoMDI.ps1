$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
$a = [Reflection.Assembly]::LoadFrom((Join-Path $PSScriptRoot 'bin/Debug/CapaVista_Compras.dll'))
$f = [Activator]::CreateInstance($a.GetType('CapaVista_Compras.FrmMDICompras'))
$flags = [Reflection.BindingFlags]'Instance,NonPublic'
function Campo($nombre) { $f.GetType().GetField($nombre,$flags).GetValue($f) }
function Clic($control) { [Windows.Forms.Button].GetMethod('OnClick',$flags).Invoke($control,@([EventArgs]::Empty)) }
$main = Campo '_ComprasPnlMain'
$dash = Campo 'ComprasUsrInicio'
$root = Campo '_ComprasTlpPrincipal'
$nav = Campo '_ComprasTlpNavegador'
$header = Campo '_ComprasTlpEncabezado'
$f.GetType().GetMethod('OnLoad',$flags).Invoke($f,@([EventArgs]::Empty))
if ($main.Controls.Count -ne 1 -or $main.Controls[0] -ne $dash) { throw 'Dashboard ausente o duplicado' }
# Real WinForms layout off screen, without showing a top-level window.
$f.Controls.Remove($root)
$root.Dock = 'None'
$root.CreateControl()
$orden = @('MovimientosProveedores','Polizas','Proveedores','MetodosPago','OrdenesCompra','PagosProveedores','AprobacionFinanciera','CierreMovimientos','Bitacora','Salir')
if ($nav.RowCount -ne 11) { throw 'Filas de navegacion incorrectas' }
for ($i=0; $i -lt $orden.Count; $i++) {
    if ($nav.GetControlFromPosition(1,$i+1) -ne (Campo ('_ComprasBtn'+$orden[$i]))) { throw 'Orden incorrecto' }
}
foreach ($button in @($nav.Controls | Where-Object { $_ -is [Windows.Forms.Button] -and $_.Name -notmatch 'Salir' })) {
    Clic $button
    if (-not $dash.Visible -or $main.Controls.Count -ne 1 -or $f.IsDisposed) { throw "Dashboard reemplazado por $($button.Name)" }
}
foreach ($size in @([Drawing.Size]::new(1100,700),[Drawing.Size]::new(1554,900),[Drawing.Size]::new(1800,1200),[Drawing.Size]::new(1100,700))) {
    $root.Size = $size
    $root.PerformLayout()
    $main.PerformLayout()
    if ($main.VerticalScroll.Visible -ne ($main.ClientSize.Height -lt $dash.MinimumSize.Height)) { throw "Barra incorrecta: $size" }
    if ($main.HorizontalScroll.Visible) { throw "Barra horizontal: $size" }
    $presentacion = $dash.Controls.Find('ComprasTlpPresentacion',$true)[0]
    $kpis = $dash.Controls.Find('ComprasTlpKpis',$true)[0]
    if ($presentacion.Height -ne 627 -or $kpis.RowCount -ne 2 -or $kpis.Controls.Count -ne 8) { throw 'Secciones comprimidas o KPI reorganizados' }
    foreach ($card in $kpis.Controls) {
        if ($card.Height -ne 162) { throw 'Altura de tarjeta modificada' }
        foreach ($other in $kpis.Controls) {
            if ($card -ne $other -and $card.Bounds.IntersectsWith($other.Bounds)) { throw 'Tarjetas superpuestas' }
        }
    }
    $headerBounds = $header.Bounds
    $navBounds = $nav.Bounds
    $main.AutoScrollPosition = [Drawing.Point]::new(0,10000)
    if ($dash.Bottom -gt $main.ClientSize.Height) { throw 'Final del dashboard inaccesible' }
    if ($header.Bounds -ne $headerBounds -or $nav.Bounds -ne $navBounds) { throw 'Encabezado o menu desplazados' }
    if ($dash.Width -ne $main.ClientSize.Width) { throw 'Dashboard no se ajusta al ancho' }
    Write-Output "Correcto: $size, dashboard fijo y desplazamiento vertical."
}
for ($i=1; $i -le 8; $i++) {
    foreach ($prefix in @('ComprasLblKpi','ComprasLblValorKpi')) {
        if ($dash.Controls.Find("$prefix$i",$true)[0].Text -ne '') { throw 'KPI no vacio' }
    }
    if ($dash.Controls.Find("ComprasPbKpi$i",$true)[0].Image -ne $null) { throw 'Imagen no vacia' }
}
Clic (Campo '_ComprasBtnAlternarNavegador')
Clic (Campo '_ComprasBtnPolizas')
if (-not $dash.Visible -or $main.Controls.Count -ne 1) { throw 'Error con menu contraido' }
Clic (Campo '_ComprasBtnAlternarNavegador')
$f.GetType().GetMethod('OnLoad',$flags).Invoke($f,@([EventArgs]::Empty))
if ($main.Controls.Count -ne 1) { throw 'Dashboard duplicado al cargar' }
$sales = [Activator]::CreateInstance($a.GetType('CapaVista_Ventas.FrmMdiVentas'))
$salesDashboard = $sales.GetType().GetField('VentasPnlDashboard',$flags).GetValue($sales)
$salesDashboard.Parent.Controls.Remove($salesDashboard)
$salesDashboard.Dock = 'None'
$salesDashboard.Size = [Drawing.Size]::new(1240,976)
$salesDashboard.CreateControl()
$main.Controls.Remove($dash)
$dash.Dock = 'None'
$dash.Size = [Drawing.Size]::new(1240,1146)
$dash.PerformLayout()
$cp = $dash.Controls.Find('ComprasTlpPresentacion',$true)[0]
$vp = $salesDashboard.Controls.Find('VentasTlpPresentacion',$true)[0]
if ($cp.Size -ne $vp.Size -or $cp.Margin -ne $vp.Margin -or $cp.Padding -ne $vp.Padding) { throw "Presentacion diferente: Compras=$($cp.Size), Ventas=$($vp.Size)" }
for ($i=0;$i -lt 4;$i++) {
    if ($cp.RowStyles[$i].SizeType -ne $vp.RowStyles[$i].SizeType -or $cp.RowStyles[$i].Height -ne $vp.RowStyles[$i].Height) { throw 'Filas diferentes' }
}
if ($cp.ColumnStyles[0].SizeType -ne $vp.ColumnStyles[0].SizeType -or $cp.ColumnStyles[0].Width -ne $vp.ColumnStyles[0].Width) { throw 'Columna diferente' }
$bitmap = [Drawing.Bitmap]::new($dash.Width,$dash.Height)
$dash.DrawToBitmap($bitmap,[Drawing.Rectangle]::new(0,0,$dash.Width,$dash.Height))
$bitmap.Save((Join-Path $PSScriptRoot 'DashboardCompras.Verificacion.png'))
$bitmap.Dispose()
Write-Output "Presentacion: Compras=$($cp.Size), Ventas=$($vp.Size); margenes, relleno, filas y columna iguales."
$salesDashboard.Dispose()
$sales.Dispose()
$dash.Dispose()
$root.Dispose()
$f.Dispose()
Write-Output 'Correcto: carga inicial, orden, opciones sin apertura, ocho KPI vacios y menu contraido.'
