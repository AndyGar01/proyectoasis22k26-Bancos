$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
Add-Type -AssemblyName System.Design
$rutaVista = Join-Path $PSScriptRoot '../CapaVista_Compras/bin/Debug/CapaVista_Compras.dll'
$ensamblado = [Reflection.Assembly]::LoadFrom((Resolve-Path $rutaVista))
$contextoAnterior = [ComponentModel.LicenseManager]::CurrentContext
[ComponentModel.LicenseManager]::CurrentContext = New-Object ComponentModel.Design.DesigntimeLicenseContext
$banderas = [Reflection.BindingFlags]'Instance,NonPublic'
$splash = $null
try {
    $tipoSplash = $ensamblado.GetType('CapaVista_Compras.FrmSplash')
    $splash = [Activator]::CreateInstance($tipoSplash)
    $splash.ShowInTaskbar = $false
    $splash.Opacity = 0
    $splash.Show()
    $paso = $tipoSplash.GetMethod('ComprasMetActualizarProgreso', $banderas)
    $relojSplash = $tipoSplash.GetField('_ComprasTmrContenido', $banderas).GetValue($splash)
    $barra = $tipoSplash.GetField('_ComprasPgbCarga', $banderas).GetValue($splash)
    $base = $ensamblado.GetType('CapaVista_Compras.Componentes.UsrBaseCompras')
    $tipoMdi = $ensamblado.GetType('CapaVista_Compras.FrmMDICompras')
    for ($indice = 0; $indice -lt 10; $indice++) {
        $paso.Invoke($splash, @($splash, [EventArgs]::Empty)) | Out-Null
        $relojSplash.Stop()
        if ($barra.Value -ne (($indice + 1) * 10)) { throw "Progreso incorrecto: paso $indice" }
        $mdi = $tipoSplash.GetField('_Principal', $banderas).GetValue($splash)
        $panel = $tipoMdi.GetField('_ComprasPnlMain', $banderas).GetValue($mdi)
        $instancias = @($panel.Controls | Where-Object { $base.IsInstanceOfType($_) })
        if ($instancias.Count -ne $indice) { throw "Precarga incorrecta: paso $indice" }
        foreach ($control in $instancias) {
            if (!$control.IsHandleCreated -or $control.Visible) { throw "Control no preparado u oculto: $($control.Name)" }
        }
    }
    $mdi.Show()
    $splash.Hide()
    if (!$mdi.Visible -or $splash.Visible -or $relojSplash.Enabled) { throw 'El splash no entrega el MDI preparado' }
    $mdi.ShowInTaskbar = $false
    $mdi.Opacity = 0
    $mostrar = $tipoMdi.GetMethod('ComprasProcMostrarControlCompras', $banderas)
    $inicio = $ensamblado.GetType('CapaVista_Compras.UsrDashboardCompras')
    $ordenes = $ensamblado.GetType('CapaVista_Compras.UsrOrdenesDeCompras')
    $mostrar.MakeGenericMethod($inicio).Invoke($mdi, @()) | Out-Null
    $mostrar.MakeGenericMethod($ordenes).Invoke($mdi, @()) | Out-Null
    $fundido = $tipoMdi.GetField('_Fundido', $banderas).GetValue($mdi)
    if (!$fundido) { throw 'No inicia la transicion' }
    $reloj = $tipoMdi.GetField('_TemporizadorTransicion', $banderas).GetValue($mdi)
    $reloj.Stop()
    $progreso = $fundido.GetType().GetProperty('Progreso', $banderas)
    foreach ($fotograma in @(@('TransicionInicio.png', 0.0), @('TransicionMitad.png', 0.5), @('TransicionFinal.png', 1.0))) {
        $progreso.SetValue($fundido, [single]$fotograma[1], $null)
        $imagen = New-Object Drawing.Bitmap($fundido.Width, $fundido.Height)
        try {
            $fundido.DrawToBitmap($imagen, (New-Object Drawing.Rectangle(0, 0, $imagen.Width, $imagen.Height)))
            $imagen.Save((Join-Path $PSScriptRoot $fotograma[0]), [Drawing.Imaging.ImageFormat]::Png)
        } finally { $imagen.Dispose() }
    }
    $terminar = $tipoMdi.GetMethod('ComprasProcTerminarTransicion', $banderas)
    $terminar.Invoke($mdi, @()) | Out-Null
    $mostrar.MakeGenericMethod($inicio).Invoke($mdi, @()) | Out-Null
    $mostrar.MakeGenericMethod($ordenes).Invoke($mdi, @()) | Out-Null
    $tiempo = [Diagnostics.Stopwatch]::StartNew()
    while ($tiempo.ElapsedMilliseconds -lt 350) {
        [Windows.Forms.Application]::DoEvents()
        Start-Sleep -Milliseconds 5
    }
    if ($tipoMdi.GetField('_Fundido', $banderas).GetValue($mdi) -or $reloj.Enabled) { throw 'La transicion no finaliza' }
    foreach ($instancia in $instancias) {
        if (!@($panel.Controls | Where-Object { [object]::ReferenceEquals($_, $instancia) }).Count) { throw 'No reutiliza las instancias precargadas' }
    }
    $mdi.Close()
    $splash.Close()
    if (!$splash.IsDisposed -or !$mdi.IsDisposed) { throw 'No libera las ventanas al cerrar' }
    $splash = [Activator]::CreateInstance($tipoSplash)
    $splash.ShowInTaskbar = $false
    $splash.Opacity = 0
    $splash.Show()
    $relojSplash = $tipoSplash.GetField('_ComprasTmrContenido', $banderas).GetValue($splash)
    for ($indice = 0; $indice -lt 10; $indice++) {
        $paso.Invoke($splash, @($splash, [EventArgs]::Empty)) | Out-Null
        $relojSplash.Stop()
    }
    $mdi = $tipoSplash.GetField('_Principal', $banderas).GetValue($splash)
    $mdi.ShowInTaskbar = $false
    $mdi.Opacity = 0
    $temporizadorCierre = New-Object Windows.Forms.Timer
    try {
        $temporizadorCierre.Interval = 100
        $temporizadorCierre.Add_Tick({ $temporizadorCierre.Stop(); $mdi.Close() })
        $temporizadorCierre.Start()
        $paso.Invoke($splash, @($splash, [EventArgs]::Empty)) | Out-Null
        if (!$splash.IsDisposed -or !$mdi.IsDisposed) { throw 'La entrega modal del splash no libera las ventanas' }
    } finally { $temporizadorCierre.Dispose() }
    Write-Output 'Validacion correcta: splash con progreso real, 9 instancias preparadas y reutilizadas, fundido, clics consecutivos y cierre.'
} catch {
    Write-Output $_.Exception.ToString()
    if ($_.Exception.InnerException) { Write-Output $_.Exception.InnerException.ToString() }
    throw
} finally {
    if ($splash -and !$splash.IsDisposed) { $splash.Dispose() }
    [ComponentModel.LicenseManager]::CurrentContext = $contextoAnterior
}
