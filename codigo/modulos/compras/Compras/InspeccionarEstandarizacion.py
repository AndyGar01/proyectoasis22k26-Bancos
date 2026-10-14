from pathlib import Path
import re

for Archivo in Path('Compras/CapaVista_Compras').glob('*.Designer.cs'):
    if Archivo.name == 'FrmMDISeguridad.Designer.cs':
        continue
    Texto = Archivo.read_text(encoding='utf-8-sig')
    print('\n' + Archivo.name)
    for Tipo, Declaracion in re.findall(r'private\s+([\w.]+)\s+([^;\n]+);', Texto):
        if Tipo.endswith('IContainer'):
            continue
        for Nombre in Declaracion.split(','):
            Nombre = Nombre.strip()
            Etiqueta = re.search(r'this\.' + re.escape(Nombre) + r'\.Text\s*=\s*"([^"]*)"', Texto)
            print(Tipo.split('.')[-1], Nombre, Etiqueta.group(1) if Etiqueta else '')
