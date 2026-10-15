$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
$assembly = [Reflection.Assembly]::LoadFrom((Join-Path $PSScriptRoot 'bin/Debug/CapaVista_Compras.dll'))
$flags = [Reflection.BindingFlags]'Instance,NonPublic'
function Assert($condition, $message) { if (!$condition) { throw $message } }
function Field($owner, $name) { $owner.GetType().GetField($name, $flags).GetValue($owner) }
function Click($button) { [Windows.Forms.Control].GetMethod('OnClick', $flags).Invoke($button, @([EventArgs]::Empty)) | Out-Null }
function Layout($control) { $control.PerformLayout(); foreach ($child in $control.Controls) { Layout $child } }
$form = $assembly.CreateInstance('CapaVista_Compras.FrmMDICompras')
try {
    $nav = Field $form '_ComprasTlpNavegador'
    $main = Field $form '_ComprasPnlMain'
    $root = Field $form '_ComprasTlpPrincipal'
    $dashboard = Field $form 'ComprasUsrInicio'
    $expected = @('Inicio','MovimientosProveedores','Proveedores','MetodosPago','OrdenesCompra','PagosProveedores','AprobacionFinanciera','CierreMovimientos','Bitacora','Salir')
    for ($i = 0; $i -lt $expected.Count; $i++) {
        $button = $nav.GetControlFromPosition(1, $i + 1)
        Assert ($button.Name -eq ('_ComprasBtn' + $expected[$i])) 'Cambió el orden de navegación.'
        Assert ($button.Image -eq $null -and $button.BackgroundImage -eq $null) 'Hay imágenes en la navegación.'
    }
    # Check original Click connections without opening permission dialogs or changing data.
    $contract = Get-Content (Join-Path $PSScriptRoot 'contratos_diseno.json') -Raw -Encoding UTF8 | ConvertFrom-Json
    $source = Get-Content (Join-Path $PSScriptRoot 'FrmMDICompras.Designer.cs') -Raw -Encoding UTF8
    foreach ($event in $contract.events) {
        Assert ($source.Contains(('this.{0}.Click += new System.EventHandler(this.{1});' -f $event[0], $event[1]))) 'Cambió una conexión Click.'
    }
    foreach ($entry in $contract.kpis.PSObject.Properties) {
        $label = Field $dashboard $entry.Name
        $expectedText = $entry.Value.Trim('"').Replace('\r', "`r").Replace('\n', "`n")
        Assert ($label.Text -eq $expectedText) ('Cambió el KPI ' + $entry.Name)
    }
    # These routes only construct controls and switch the visible view; the hidden form does not load DB data.
    foreach ($route in @(@('OrdenesCompra','UsrOrdenesDeCompras'), @('AprobacionFinanciera','UsrOrdenesDisponibles'), @('Inicio','UsrDashboardCompras'))) {
        Click (Field $form ('_ComprasBtn' + $route[0]))
        Assert (@($main.Controls | Where-Object { $_.GetType().Name -eq $route[1] }).Count -eq 1) 'No se abrió el destino de navegación.'
    }
    Click (Field $form '_ComprasBtnIconoInicio')
    Assert (@($main.Controls | Where-Object { $_ -is [CapaVista_Compras.UsrDashboardCompras] }).Count -eq 1) 'El icono duplicó el dashboard.'
    foreach ($size in @(@(1554,1055), @(1100,700), @(1920,1080))) {
        $form.ClientSize = New-Object Drawing.Size($size[0], $size[1])
        Layout $form
        Assert ($nav.Width -eq 270) 'Ancho del menú expandido incorrecto.'
        Assert ($main.Left -eq 300) 'Margen del contenido incorrecto.'
        $kpis = Field $dashboard '_ComprasTlpKpis'
        for ($i = 1; $i -le 4; $i++) {
            $card = Field $dashboard ('_ComprasPnlKPI' + $i)
            Assert ($card.Width -gt 0 -and $card.Height -gt 140) 'Tarjeta KPI recortada.'
            Assert ($card.Bottom -le $kpis.ClientSize.Height) 'KPI fuera del área disponible.'
        }
        Click (Field $form '_ComprasBtnAlternarNavegador')
        Layout $form
        Assert ($nav.Width -eq 64 -and $main.Left -eq 200) 'Menú contraído incorrecto.'
        Click (Field $form '_ComprasBtnAlternarNavegador')
        Layout $form
        Assert ($nav.Width -eq 270 -and $main.Left -eq 300) 'No se restauró el menú.'
    }
    $form.ClientSize = New-Object Drawing.Size(1554,1055)
    Layout $form
    # Detach the presentation from the hidden form so DrawToBitmap paints its children.
    $root.Parent = $null
    $root.CreateControl()
    Layout $root
    $bitmap = New-Object Drawing.Bitmap($root.Width, $root.Height)
    try {
        $root.DrawToBitmap($bitmap, (New-Object Drawing.Rectangle(0,0,$root.Width,$root.Height)))
        $bitmap.Save((Join-Path $PSScriptRoot 'VistaPreviaMDICompras.png'))
    } finally { $bitmap.Dispose() }
    'OK: orden, eventos, navegación, cuatro KPI, imágenes vacías y ajuste de tamaño en tres resoluciones.'
} finally { $root.Dispose(); $form.Dispose() }
