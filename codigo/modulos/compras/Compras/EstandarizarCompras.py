from pathlib import Path
import re
import unicodedata
import json

Raiz = Path('Compras')
Vista = Raiz / 'CapaVista_Compras'
Token = re.compile(r'//[^\n]*|/\*[\s\S]*?\*/|@"(?:[^"]|"")*"|"(?:\\.|[^"\\])*"|\b\w+\b')

def CambiarCodigo(Texto, Cambios):
    return Token.sub(lambda Coincidencia: Cambios.get(Coincidencia.group(), Coincidencia.group()), Texto)

def Guardar(Archivo, Texto):
    Archivo.write_text(Texto, encoding='utf-8-sig', newline='\r\n')

def Nombre(Texto):
    Texto = unicodedata.normalize('NFKD', Texto)
    Texto = ''.join(Letra for Letra in Texto if not unicodedata.combining(Letra))
    return ''.join(Palabra[:1].upper() + Palabra[1:].lower() for Palabra in re.findall(r'[A-Za-z0-9]+', Texto))

Clases = {'Usr'+Base: 'Cls'+Base for Base in ['BaseCompras','ComboBoxCompras','DataGridViewCompras','LabelCompras','TextBoxCompras','CierreMovimientos','DashboardCompras','EstadoDeCuenta','EvaluarOrden','MantenimientoMetodoPago','MantenimientoProveedor','OrdenesDeCompras','OrdenesDisponibles','PagosProveedores']}
if (Vista / 'Componentes/UsrComboBoxCompras.cs').exists() and (Vista / 'Componentes/ClsComboBoxCompras.cs').exists():
    for Extension in ['.cs','.Designer.cs','.resx']:
        Archivo = Vista / ('Componentes/ClsComboBoxCompras' + Extension)
        Guardar(Archivo, Archivo.read_text(encoding='utf-8-sig').replace('ClsComboBoxCompras','ClsSelectorCompras'))
        Archivo.rename(Archivo.with_name('ClsSelectorCompras'+Extension))
    Archivo = Vista / 'ClsEstadoDeCuenta.Designer.cs'
    if not Archivo.exists():
        Archivo = Vista / 'UsrEstadoDeCuenta.Designer.cs'
    Guardar(Archivo, Archivo.read_text(encoding='utf-8-sig').replace('ClsComboBoxCompras','ClsSelectorCompras'))
    Archivo = Vista / 'CapaVista_Compras.csproj'
    Texto = Archivo.read_text(encoding='utf-8-sig')
    Inicio = Texto.index('    <Compile Include="Componentes\\ClsComboBoxCompras.cs">')
    Fin = Texto.index('    <Compile Include="Componentes\\ClsGroupBoxCompras.cs">', Inicio)
    Texto = Texto[:Inicio] + Texto[Inicio:Fin].replace('ClsComboBoxCompras','ClsSelectorCompras') + Texto[Fin:]
    Inicio = Texto.index('    <EmbeddedResource Include="Componentes\\ClsComboBoxCompras.resx">')
    Fin = Texto.index('    </EmbeddedResource>',Inicio) + len('    </EmbeddedResource>')
    Texto = Texto[:Inicio] + Texto[Inicio:Fin].replace('ClsComboBoxCompras','ClsSelectorCompras') + Texto[Fin:]
    Guardar(Archivo,Texto)

Especiales = {
    'FrmMDICompras': {
        'clsTableLayoutPanelCompras1': 'ComprasTlpPrincipal',
        'clsTableLayoutPanelNavegadorCompras': 'ComprasTlpNavegador',
        'clsTableLayoutPanelCompras2': 'ComprasTlpEncabezado',
        'pictureBox1': 'ComprasPbMarca',
        'usrDashboardCompras1': 'ComprasPnlInicio',
        'ComprasBtnBurger': 'ComprasBtnAlternarNavegador',
        'ComprasBtnDashboard': 'ComprasBtnInicio',
        'clsButtonCompras2': 'ComprasBtnIconoSalir',
        'clsButtonCompras3': 'ComprasBtnIconoInicio',
    },
    'FrmSplash': {'pictureBox2': 'ComprasPbMarca'},
    'UsrOrdenesDeCompras': {},
    'UsrEstadoDeCuenta': {
        'dateTimePicker1': 'ComprasDtpDesde', 'dateTimePicker2': 'ComprasDtpHasta',
        'clsComboBoxCompras1': 'ComprasCboTipoMovimiento', 'clsComboBoxCompras2': 'ComprasCboEstado',
        'clsPanelCompras1': 'ComprasPnlFiltros', 'clsPanelCompras2': 'ComprasPnlProveedor',
        'clsEtiquetaCompras9': 'ComprasLblSeparadorTelefono', 'clsEtiquetaCompras10': 'ComprasLblSeparadorCorreo',
        'clsEtiquetaCompras6': 'ComprasLblNombreProveedor',
        'clsEtiquetaCompras7': 'ComprasLblTituloNit', 'clsEtiquetaCompras8': 'ComprasLblTituloTelefono',
    },
}
for Indice, Accion in enumerate(['MovimientosProveedores', 'Proveedores', 'MetodosPago', 'OrdenesCompra', 'PagosProveedores', 'AprobacionFinanciera', 'CierreMovimientos', 'Bitacora'], 1):
    Especiales['FrmMDICompras']['clsButtonMDICompras' + str(Indice)] = 'ComprasBtn' + Accion
    Especiales['FrmMDICompras']['button' + str(Indice)] = 'ComprasBtnIcono' + Accion

Orden = Especiales['UsrOrdenesDeCompras']
for Indice, Campo in {1:'Subtotal',2:'Descuento',3:'NombreProveedor',4:'CodigoResponsable',5:'TelefonoProveedor',6:'CorreoProveedor',7:'ContactoProveedor',8:'NombreResponsable',9:'PuestoResponsable',10:'CorreoResponsable',11:'GastosAdicionales',12:'Total',13:'Impuesto',14:'Comentario'}.items():
    Orden['usrTextBoxCompras' + str(Indice)] = 'ComprasTxt' + Campo
for Indice, Campo in {1:'Subtotal',2:'Descuento',3:'GastosAdicionales',4:'CodigoResponsable',5:'NombreResponsable',6:'PuestoResponsable',7:'CorreoResponsable',8:'Responsable',9:'Proveedor',10:'NombreProveedor',11:'TelefonoProveedor',12:'CorreoProveedor',13:'ContactoProveedor',14:'Impuesto',15:'Total',16:'Comentario'}.items():
    Orden['usrLabelCompras' + str(Indice)] = 'ComprasLbl' + Campo
for Indice, Campo in {1:'Principal',2:'Totales',3:'Detalles',4:'Finalizacion',5:'Importes',6:'Encabezado',7:'Responsable',8:'Proveedor',9:'Acciones'}.items():
    Orden['clsTableLayoutPanelCompras' + str(Indice)] = 'ComprasTlp' + Campo
for Indice, Campo in {1:'Encabezado',2:'Finalizacion',3:'Detalles'}.items():
    Orden['clsGroupBoxCompras' + str(Indice)] = 'ComprasGbx' + Campo
Orden.update({'clsConsultasCompras1':'ComprasBtnConsultarResponsable','clsConsultasCompras2':'ComprasBtnConsultarProveedor','clsButtonCompras1':'ComprasBtnDescartar','clsButtonCompras2':'ComprasBtnGuardar','clsButtonCompras5':'ComprasBtnPorcentaje','clsPanelCompras1':'ComprasPnlArticulos','usrDataGridViewCompras1':'ComprasDgvArticulos'})
for Indice, Campo in enumerate(['Articulos','Logistica','Finanzas','Anexos'],1):
    Orden['clsButtonMDICompras'+str(Indice)] = 'ComprasBtn'+Campo

Tipos = {'Button':'Btn','ClsButtonCompras':'Btn','ClsConsultasCompras':'Btn','Label':'Lbl','UsrLabelCompras':'Lbl','ClsEtiquetaCompras':'Lbl','TextBox':'Txt','UsrTextBoxCompras':'Txt','ComboBox':'Cbo','UsrComboBoxCompras':'Cbo','ClsComboBoxCompras':'Cbo','Panel':'Pnl','ClsPanelCompras':'Pnl','PictureBox':'Pb','DateTimePicker':'Dtp','UsrDataGridViewCompras':'Dgv','DataGridView':'Dgv','ClsTableLayoutPanelCompras':'Tlp','ClsGroupBoxCompras':'Gbx','ProgressBar':'Pgb','Navegador':'Pnl','Timer':'Tmr','UsrDashboardCompras':'Pnl','DataGridViewColumn':'Col'}
Registro = {}
for Disenador in Vista.rglob('*.Designer.cs'):
    if 'Properties' in Disenador.parts or Disenador.name == 'FrmMDISeguridad.Designer.cs':
        continue
    Clase = Disenador.name.replace('.Designer.cs','')
    Texto = Disenador.read_text(encoding='utf-8-sig')
    Campos = {'components':'_Componentes','disposing':'LiberarRecursos'}
    NombresControles = {}
    for Tipo, Declaracion in re.findall(r'private\s+([\w.]+)\s+([^;\n]+);', Texto):
        Tipo = Tipo.split('.')[-1]
        if Tipo not in Tipos:
            continue
        for Campo in Declaracion.split(','):
            Campo = Campo.strip().split('=')[0].strip()
            if Campo in Especiales.get(Clase, {}):
                Nuevo = Especiales[Clase][Campo]
            elif Campo.lstrip('_').startswith('Compras'):
                Nuevo = Campo.lstrip('_').replace('ComprasUsrError','ComprasLblError').replace('Evaluación','Evaluacion')
            elif Campo.startswith('Seguridad'):
                Nuevo = 'Compras' + Campo[len('Seguridad'):]
            elif Tipo == 'DataGridViewColumn':
                Nuevo = 'ComprasCol' + Campo.replace('_','')
            elif re.match(r'^(Pnl|Lbl|Btn|Tlp|Cbo|Txt|Dgv|Gb)', Campo):
                Nuevo = 'Compras' + re.sub(r'^Gb(?!x)', 'Gbx', Campo)
            elif Campo == 'navegador1':
                Nuevo = 'ComprasPnlMantenimiento'
            else:
                Etiqueta = re.search(r'this\.' + re.escape(Campo) + r'\.Text\s*=\s*"([^"]*)"', Texto)
                Sufijo = Nombre(Etiqueta.group(1)) if Etiqueta and Etiqueta.group(1).strip() else 'Contenido'
                Nuevo = 'Compras' + Tipos[Tipo] + Sufijo
            if Nuevo in NombresControles.values():
                raise ValueError((Clase, Campo, Nuevo))
            NombresControles[Campo] = Nuevo
            Campos[Campo] = '_' + Nuevo
    Codigo = Disenador.with_name(Clase + '.cs')
    MetodoCambios = {}
    if Codigo.exists():
        Fuente = Codigo.read_text(encoding='utf-8-sig')
        for Retorno, Metodo in re.findall(r'private\s+(?:static\s+)?([\w.<>]+)\s+(\w+)\s*(?:<[^>]+>)?\(', Fuente):
            if Metodo.startswith('Compras'):
                continue
            if Metodo == 'SetWindowTheme':
                continue
            Base = Metodo
            for Viejo, Nuevo in NombresControles.items():
                if Metodo.startswith(Viejo+'_'):
                    Base = Nuevo.removeprefix('Compras') + Metodo[len(Viejo):].replace('_','')
                    break
            MetodoCambios[Metodo] = ('ComprasProc' if Retorno == 'void' and '_' not in Metodo else 'ComprasMet' if Retorno == 'void' else 'ComprasFunc') + Base[:1].upper() + Base[1:]
        Campos.update({'movimientos':'_Movimientos','dtMovimientos':'_TablaMovimientos','pagos':'_Pagos','dtPagos':'_TablaPagos','sender':'Remitente','e':'Evento','control':'ControlActual','otroControl':'OtroControl','boton':'Boton','columna':'Columna','i':'Indice','t':'Tabla','col':'Columna','nombre':'Nombre','texto':'Texto','estado':'Estado','seleccionada':'Seleccionada','fondo':'Fondo','pincel':'Pincel','tamano':'Tamano','referencia':'Referencia','titulo':'EsTitulo'})
        Campos.update(MetodoCambios)
    for Archivo in [Disenador, Codigo]:
        if not Archivo.exists():
            continue
        Fuente = Archivo.read_text(encoding='utf-8-sig')
        Fuente = CambiarCodigo(Fuente, Campos)
        for Viejo, Nuevo in NombresControles.items():
            Fuente = Fuente.replace('"' + Viejo + '"', '"' + Nuevo + '"')
            Fuente = Fuente.replace('"' + Viejo + '.', '"' + Nuevo + '.')
        Guardar(Archivo, Fuente)
    Recurso = Disenador.with_name(Clase + '.resx')
    if Recurso.exists():
        Fuente = Recurso.read_text(encoding='utf-8-sig')
        for Viejo, Nuevo in NombresControles.items():
            Fuente = Fuente.replace('name="'+Viejo+'.','name="'+Nuevo+'.')
        Guardar(Recurso, Fuente)
    Registro[Clase] = NombresControles

for Archivo in list(Raiz.rglob('*')) + list(Path('Ejecucion_Compras').rglob('*')):
    if not Archivo.is_file() or any(Parte in ('bin','obj','sources','Properties') for Parte in Archivo.parts) or Archivo.suffix not in ('.cs','.csproj','.resx'):
        continue
    Texto = Archivo.read_text(encoding='utf-8-sig')
    for Viejo, Nuevo in Clases.items():
        Texto = re.sub(r'\b'+Viejo+r'\b', Nuevo, Texto)
    if Archivo.name == 'Program.cs':
        Texto = CambiarCodigo(Texto, {'Program':'ClsPrograma'})
    if Archivo.name == 'ClsTemaCompras.cs':
        Texto = CambiarCodigo(Texto, {'Mezclar':'ComprasFuncMezclar'})
    if Archivo.name in ('UsrLabelCompras.cs','ClsLabelCompras.cs'):
        Texto = CambiarCodigo(Texto, {'AplicarTipografia':'ComprasProcAplicarTipografia'})
    Guardar(Archivo, Texto)
    for Viejo, Nuevo in Clases.items():
        if Archivo.name.startswith(Viejo + '.'):
            Archivo.rename(Archivo.with_name(Nuevo + Archivo.name[len(Viejo):]))
            break

(Raiz / 'Validacion').mkdir(exist_ok=True)
(Raiz / 'Validacion/Renombres.json').write_text(json.dumps({'Clases':Clases,'Controles':Registro}, ensure_ascii=False, indent=2), encoding='utf-8')
print('Clases:', len(Clases), 'Controles:', sum(map(len,Registro.values())))
