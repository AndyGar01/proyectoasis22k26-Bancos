$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
[Windows.Forms.Application]::EnableVisualStyles()
$assembly = [Reflection.Assembly]::LoadFrom((Join-Path $PSScriptRoot 'bin/Debug/CapaVista_Compras.dll'))
$form = $assembly.CreateInstance('CapaVista_Ventas.FrmMdiVentas')
try { [Windows.Forms.Application]::Run($form) } finally { $form.Dispose() }
