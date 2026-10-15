$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
$a = [Reflection.Assembly]::LoadFrom((Join-Path $PSScriptRoot 'bin/Debug/CapaVista_Compras.dll'))
$f = [Activator]::CreateInstance($a.GetType('CapaVista_Compras.FrmMDICompras'))
$flags = [Reflection.BindingFlags]'Instance,NonPublic'
$f.GetType().GetMethod('OnLoad',$flags).Invoke($f,@([EventArgs]::Empty))
$main = $f.GetType().GetField('_ComprasPnlMain',$flags).GetValue($f)
$dash = @($main.Controls | Where-Object { $_.GetType().Name -eq 'UsrDashboardCompras' })
if ($dash.Count -ne 1) { throw 'Dashboard duplicado o ausente' }
$d = $dash[0]
if ($d.Dock -ne [Windows.Forms.DockStyle]::Fill) { throw 'Dashboard sin ajuste al MDI' }
$main.Controls.Remove($d)
$d.Dock = [Windows.Forms.DockStyle]::None
$d.Visible = $true
function Campo($nombre) { $d.GetType().GetField($nombre,$flags).GetValue($d) }
for ($i=1;$i -le 8;$i++) {
    if ((Campo "ComprasLblValorKpi$i").Text -ne '' -or (Campo "ComprasLblKpi$i").Text -ne '') { throw "KPI $i no vacio" }
    if ((Campo "ComprasPbKpi$i").Image -ne $null) { throw "Imagen $i no vacia" }
}
foreach ($width in @(700,1000,1240,1807)) {
    $d.Size = New-Object Drawing.Size($width,976)
    $d.PerformLayout()
    $table = Campo 'ComprasTlpKpis'
    $cards = @($table.Controls)
    if ($cards.Count -ne 8 -or $table.ColumnCount -ne 4 -or $table.RowCount -ne 2) { throw 'Cantidad incorrecta' }
    foreach ($card in $cards) {
        if ($card.Bottom -gt $table.ClientSize.Height) { throw 'Tarjeta fuera de limites' }
        foreach ($other in $cards) {
            if ($card -ne $other -and $card.Bounds.IntersectsWith($other.Bounds)) { throw 'Tarjetas superpuestas' }
        }
    }
    foreach ($card in $cards) {
        if ($card.Width -le 0 -or $card.Height -lt 150 -or $card.Right -gt $table.ClientSize.Width) { throw "Tarjeta fuera de límites en $width" }
    }
    $bitmap = New-Object Drawing.Bitmap($d.Width,$d.Height)
    $d.DrawToBitmap($bitmap,[Drawing.Rectangle]::new(0,0,$d.Width,$d.Height))
    if ($width -eq 1240) { $bitmap.Save((Join-Path $PSScriptRoot 'DashboardCompras.Verificacion.png')) }
    $bitmap.Dispose()
    Write-Output "Distribución correcta: $width"
}
$d.Size = [Drawing.Size]::new(700,800)
$d.PerformLayout()
if ((Campo 'ComprasTlpKpis').Height -lt 330) { throw 'Tarjetas recortadas en tamano minimo' }
$d.Scale([Drawing.SizeF]::new(1.25,1.25))
$d.PerformLayout()
if ((Campo 'ComprasTlpKpis').Controls.Count -ne 8) { throw 'Error de escalado' }
Write-Output 'Tamano minimo y escalado al 125% correctos'
$f.Dispose()
