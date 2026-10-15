$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
Add-Type -AssemblyName System.Design
$rutaVista = Join-Path $PSScriptRoot '../CapaVista_Compras/bin/Debug/CapaVista_Compras.dll'
$ensamblado = [Reflection.Assembly]::LoadFrom((Resolve-Path $rutaVista))
$contextoAnterior = [ComponentModel.LicenseManager]::CurrentContext
[ComponentModel.LicenseManager]::CurrentContext = New-Object ComponentModel.Design.DesigntimeLicenseContext
$banderas = [Reflection.BindingFlags]'Instance,NonPublic'
$mdi = $null
try {
    $base = $ensamblado.GetType('CapaVista_Compras.Componentes.UsrBaseCompras')
    $tipos = @($ensamblado.GetTypes() | Where-Object { $_.IsSubclassOf($base) -and !$_.IsAbstract })
    foreach ($tipo in $tipos) {
        $control = [Activator]::CreateInstance($tipo)
        try {
            $propiedades = [ComponentModel.TypeDescriptor]::GetProperties($control)
            foreach ($nombre in @('AnchoMinimo', 'AnchoMaximo', 'AnchoMaximizado')) {
                if (!$propiedades[$nombre].IsBrowsable -or $propiedades[$nombre].IsReadOnly) {
                    throw "$($tipo.Name): propiedad $nombre no editable en el disenador"
                }
            }
            if ($control.AutoScaleMode -ne [Windows.Forms.AutoScaleMode]::Inherit) { throw "$($tipo.Name): escala incorrecta" }
            if ($control.AnchoMinimo -ne 1610 -or $control.AnchoMaximo -ne 1807) { throw "$($tipo.Name): limites incorrectos" }
            if ($control.MinimumSize.Height -ne 0 -or $control.MaximumSize.Height -ne 0) { throw "$($tipo.Name): altura limitada" }
            $control.AutoSize = $false
            foreach ($altura in @(200, 1000)) {
                $control.Height = $altura
                $control.AnchoMaximizado = $true
                if ($control.Width -ne 1807 -or $control.Height -ne $altura) { throw "$($tipo.Name): vista maxima cambia altura" }
                $control.AnchoMaximizado = $false
                if ($control.Width -ne 1610 -or $control.Height -ne $altura) { throw "$($tipo.Name): vista minima cambia altura" }
            }
            $control.AutoScaleMode = [Windows.Forms.AutoScaleMode]::Font
            if ($control.AutoScaleMode -ne [Windows.Forms.AutoScaleMode]::Inherit) { throw "$($tipo.Name): permite reemplazar escala" }
        } finally { $control.Dispose() }
    }
    $tipoMdi = $ensamblado.GetType('CapaVista_Compras.FrmMDICompras')
    $mdi = [Activator]::CreateInstance($tipoMdi)
    $mdi.ShowInTaskbar = $false
    $mdi.Opacity = 0
    $mdi.WindowState = [Windows.Forms.FormWindowState]::Normal
    $mdi.ClientSize = New-Object Drawing.Size(1902, 853)
    $mdi.Show()
    $mdi.ClientSize = New-Object Drawing.Size(1902, 853)
    $panel = $tipoMdi.GetField('_ComprasPnlMain', $banderas).GetValue($mdi)
    $mostrar = $tipoMdi.GetMethod('ComprasProcMostrarControlCompras', $banderas)
    $burger = $tipoMdi.GetMethod('ComprasBtnBurger_Click', $banderas)
    $principal = $tipoMdi.GetField('_ComprasTlpPrincipal', $banderas).GetValue($mdi)
    foreach ($tipo in $tipos) {
        $mostrar.MakeGenericMethod($tipo).Invoke($mdi, @()) | Out-Null
        $control = @($panel.Controls | Where-Object { $_.GetType() -eq $tipo })[0]
        foreach ($estado in @(0, 1)) {
            $panel.PerformLayout()
            if ($control.Left -ne $panel.Padding.Left -or $control.Right -gt $panel.ClientSize.Width - $panel.Padding.Right -or $panel.HorizontalScroll.Visible) {
                throw "$($tipo.Name): fuera del marco real del MDI, estado $estado"
            }
            $burger.Invoke($mdi, @($mdi, [EventArgs]::Empty)) | Out-Null
        }
    }
    $principal.Dock = [Windows.Forms.DockStyle]::None
    $principal.Size = New-Object Drawing.Size(1902, 853)
    foreach ($tipo in $tipos) {
        $mostrar.MakeGenericMethod($tipo).Invoke($mdi, @()) | Out-Null
        $control = @($panel.Controls | Where-Object { $_.GetType() -eq $tipo })[0]
        $panel.PerformLayout()
        $anchoExpandido = $control.Width
        $burger.Invoke($mdi, @($mdi, [EventArgs]::Empty)) | Out-Null
        $panel.PerformLayout()
        if ($control.Width -le $anchoExpandido -or $control.Width -gt $control.AnchoMaximo) { throw "$($tipo.Name): no se adapta al contraer menu ($anchoExpandido -> $($control.Width)); panel=$($panel.ClientSize), visible=$($control.Visible), mdi=$($mdi.ClientSize), principal=$($principal.ClientSize), columnas=$($principal.GetColumnWidths() -join ','), estilos=$($principal.ColumnStyles[0].Width), display=$($panel.DisplayRectangle)" }
        $burger.Invoke($mdi, @($mdi, [EventArgs]::Empty)) | Out-Null
        $panel.PerformLayout()
        if ($control.Width -ne $anchoExpandido) { throw "$($tipo.Name): no recupera ancho al expandir menu" }
        $principal.Width = 1000
        $panel.PerformLayout()
        if ($control.Left -lt 0 -or $control.Right -gt $panel.ClientSize.Width - $panel.Padding.Right -or $panel.HorizontalScroll.Visible) { throw "$($tipo.Name): contenido fuera del marco en ventana pequena" }
        $alturaAnterior = $control.Height
        $principal.Height = 400
        $panel.PerformLayout()
        if (!$panel.VerticalScroll.Visible -or $control.Height -ne $alturaAnterior) { throw "$($tipo.Name): no conserva altura con desplazamiento" }
        if ($control.Right -gt $panel.ClientSize.Width - $panel.Padding.Right -or $panel.HorizontalScroll.Visible) { throw "$($tipo.Name): se sale del marco al aparecer la barra vertical" }
        $panel.AutoScrollPosition = New-Object Drawing.Point(0, 100)
        $burger.Invoke($mdi, @($mdi, [EventArgs]::Empty)) | Out-Null
        $panel.PerformLayout()
        if ($control.Left -ne $panel.Padding.Left -or $control.Right -gt $panel.ClientSize.Width - $panel.Padding.Right) { throw "$($tipo.Name): desplazamiento horizontal al alternar menu despues de desplazar" }
        $burger.Invoke($mdi, @($mdi, [EventArgs]::Empty)) | Out-Null
        $principal.Size = New-Object Drawing.Size(1902, 853)
        $panel.PerformLayout()
        $control.AnchoMinimo = 900
        $control.AnchoMaximo = 1200
        $panel.PerformLayout()
        if ($control.Width -ne 1200 -or $control.Height -ne $alturaAnterior) { throw "$($tipo.Name): no aplica limites personalizados: ancho=$($control.Width), altura=$($control.Height), anterior=$alturaAnterior, limites=$($control.AnchoMinimo),$($control.AnchoMaximo)" }
        $control.AnchoMaximo = 1807
        $control.AnchoMinimo = 1610
    }
    $etiqueta = $tipoMdi.GetField('ComprasUsrUsuario', $banderas).GetValue($mdi)
    if ($etiqueta.Text -ne 'Usuario: Sin sesi' + [char]0xF3 + 'n  Rol: ') { throw 'Texto de usuario y rol incorrecto' }
    $encabezado = $tipoMdi.GetField('_ComprasTlpEncabezado', $banderas).GetValue($mdi)
    if ($encabezado.Controls.Count -ne 2) { throw 'El encabezado no tiene una sola etiqueta y el burger' }
    Write-Output "Validacion correcta: $($tipos.Count) controles, propiedades de disenador, alturas libres, escala heredada y menu en ambos estados."
} catch {
    Write-Output $_.Exception.ToString()
    if ($_.Exception.InnerException) { Write-Output $_.Exception.InnerException.ToString() }
    throw
} finally {
    if ($mdi) { $mdi.Dispose() }
    [ComponentModel.LicenseManager]::CurrentContext = $contextoAnterior
}
