$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
$a = [Reflection.Assembly]::LoadFrom((Join-Path $PSScriptRoot 'bin/Debug/CapaVista_Compras.dll'))
$f = [Activator]::CreateInstance($a.GetType('CapaVista_Compras.FrmMDICompras'))
$flags = [Reflection.BindingFlags]'Instance,NonPublic'
function Campo($nombre) { $f.GetType().GetField($nombre,$flags).GetValue($f) }
$root = Campo '_ComprasTlpPrincipal'
$main = Campo '_ComprasPnlMain'
$dash = Campo 'usrDashboardCompras1'
$f.Controls.Remove($root)
$root.Dock = 'None'
$root.CreateControl()
foreach ($size in @([Drawing.Size]::new(1100,660),[Drawing.Size]::new(1554,1015),[Drawing.Size]::new(1920,1040))) {
    $root.Size = $size
    $root.PerformLayout()
    $main.PerformLayout()
    if ($main.AutoScroll -or $main.VerticalScroll.Visible -or $main.HorizontalScroll.Visible) { throw 'Desplazamiento activo' }
    if ($dash.Size -ne $main.ClientSize -or $main.Controls.Count -ne 1) { throw 'Dashboard no se ajusta o esta duplicado' }
    $table = $dash.Controls.Find('ComprasTlpDashboard',$true)[0]
    foreach ($section in $table.Controls) {
        if ($section.Top -lt 0 -or $section.Bottom -gt $table.ClientSize.Height -or $section.Right -gt $table.ClientSize.Width) { throw "Seccion recortada: $($section.Name)" }
        foreach ($other in $table.Controls) {
            if ($section -ne $other -and $section.Bounds.IntersectsWith($other.Bounds)) { throw 'Secciones superpuestas' }
        }
    }
    if ($size.Width -eq 1100) {
        $bitmap = [Drawing.Bitmap]::new($root.Width,$root.Height)
        $root.DrawToBitmap($bitmap,[Drawing.Rectangle]::new(0,0,$root.Width,$root.Height))
        $path = Join-Path $env:TEMP 'ComprasDashboardSinScroll.png'
        $bitmap.Save($path)
        $bitmap.Dispose()
        Write-Output "Captura: $path"
    }
    Write-Output "Correcto: $size, dashboard entero y sin barras."
}
$root.Dispose()
$f.Dispose()
