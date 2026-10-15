# Capturas PNG y transiciones de Compras

Windows Forms permite dibujar un formulario o un control de usuario en un `Bitmap` mediante `DrawToBitmap`. Ese bitmap puede guardarse como PNG o utilizarse directamente en una transicion.

## Guardar un formulario o control como PNG

Agrega estos espacios de nombres al archivo C#:

```csharp
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
```

Este metodo acepta cualquier `Control`, incluidos formularios y controles de usuario:

```csharp
private void GuardarControlComoPng(Control control, string ruta)
{
    if (control == null)
        throw new ArgumentNullException(nameof(control));

    if (control.IsDisposed)
        throw new ObjectDisposedException(control.Name);

    if (control.Width <= 0 || control.Height <= 0)
        throw new InvalidOperationException("El control debe tener un tamano positivo.");

    string rutaCompleta = Path.GetFullPath(ruta);
    Directory.CreateDirectory(Path.GetDirectoryName(rutaCompleta));

    control.CreateControl();
    control.PerformLayout();

    using (Bitmap imagen = new Bitmap(control.Width, control.Height))
    {
        control.DrawToBitmap(
            imagen,
            new Rectangle(Point.Empty, control.Size));

        imagen.Save(rutaCompleta, ImageFormat.Png);
    }
}
```

Ejecuta el metodo en el hilo de la interfaz, por ejemplo desde el evento `Click` de un boton. Captura despues de que el control termine de cargar y tenga su tamano definitivo.

Para guardar un control de usuario desde `FrmMDICompras`:

```csharp
string carpeta = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
    "CapturasCompras");

GuardarControlComoPng(
    ComprasUsrActual,
    Path.Combine(carpeta, "Ordenes.png"));
```

`ComprasUsrActual` representa la instancia que quieres capturar. En el MDI actual es una variable local de `ComprasProcMostrarControlCompras<T>()`; fuera de ese metodo debes obtener la instancia desde el panel o pasarla como argumento.

Para guardar el formulario desde uno de sus propios eventos:

```csharp
GuardarControlComoPng(
    this,
    Path.Combine(carpeta, "ComprasMDI.png"));
```

La captura del formulario representa el contenido dibujado por sus controles. No equivale a una captura de pantalla con el marco y la barra de titulo de Windows.

## Capturar el area visible del MDI

Para las transiciones interesa capturar el panel donde se muestran las pantallas, conservando el mismo encuadre antes y despues del cambio.

El metodo actual `ComprasFuncCapturarContenido()` de [FrmMDICompras.cs](CapaVista_Compras/FrmMDICompras.cs) crea un bitmap con el `ClientSize` de `_ComprasPnlMain` y dibuja el panel en esa imagen:

```csharp
var imagen = new Bitmap(
    _ComprasPnlMain.ClientSize.Width,
    _ComprasPnlMain.ClientSize.Height);

_ComprasPnlMain.DrawToBitmap(
    imagen,
    new Rectangle(Point.Empty, imagen.Size));
```

Al usar el tamano visible del panel, la imagen tiene las dimensiones del area de contenido. Si hay desplazamiento vertical, no se genera automaticamente una imagen de toda la pantalla extensa. Para exportar el control completo, utiliza el primer metodo sobre la instancia del control de usuario.

## Como funciona la transicion actual

El flujo en `ComprasProcMostrarControlCompras<T>()` es:

1. Finaliza cualquier fundido pendiente y obtiene la instancia del control solicitado.
2. Captura el panel con la pantalla anterior.
3. Oculta la pantalla anterior, muestra la siguiente y ajusta su ancho al espacio disponible.
4. Captura el panel con la nueva pantalla.
5. Coloca una capa temporal, `ClsFundidoCompras`, sobre el area de contenido.
6. Mezcla ambas imagenes durante 180 milisegundos.
7. Retira la capa, libera los bitmaps y deja el control real disponible para interactuar.

El temporizador solicita actualizaciones cada 16 milisegundos. El avance se calcula con el tiempo transcurrido, por lo que la duracion no depende de contar un numero fijo de eventos.

En `ClsFundidoCompras.OnPaint()` se dibuja primero la imagen anterior. Luego se dibuja la nueva con una opacidad creciente mediante `ImageAttributes` y `ColorMatrix`:

```csharp
float opacidad = progreso * progreso * (3F - 2F * progreso);

var matriz = new System.Drawing.Imaging.ColorMatrix
{
    Matrix33 = opacidad
};
```

La curva hace que el fundido comience y termine gradualmente. Al pulsar el burger o cambiar el tamano del panel, se termina la transicion para evitar que la imagen temporal quede desalineada.

La propiedad `TransicionesSuaves` del MDI permite activar o desactivar el efecto:

```csharp
TransicionesSuaves = false;
```

## PNG en disco o bitmap en memoria

| Uso | Opcion adecuada |
| --- | --- |
| Documentar una pantalla o compartir una captura | Guardar PNG |
| Revisar el inicio, mitad y final de un fundido | Guardar PNG de cada etapa |
| Mostrar una transicion con los datos actuales | Mantener los bitmaps en memoria |

La transicion actual trabaja con bitmaps en memoria. No necesita leer ni escribir archivos PNG en cada cambio de pantalla. Esto permite utilizar el contenido actual y evita el trabajo adicional de acceso al disco.

## Ejemplos generados en este proyecto

La validacion guarda tres capturas del cambio de Inicio a Ordenes:

- [Inicio del fundido](Validacion/TransicionInicio.png)
- [Mitad del fundido](Validacion/TransicionMitad.png)
- [Final del fundido](Validacion/TransicionFinal.png)

Puedes regenerarlas desde la carpeta de la solucion, despues de compilar en Debug:

```powershell
& ./Validacion/ValidarCargaYTransiciones.ps1
```

El script utiliza formularios de prueba, comprueba la precarga y la reutilizacion de las instancias, y dibuja la capa de transicion con avances de 0%, 50% y 100%.

## Consideraciones al capturar

- `CreateControl()` y `PerformLayout()` preparan el control para dibujarlo, pero no esperan consultas de datos ni operaciones asincronas. Si existe una carga pendiente, captura cuando termine.
- Algunos controles nativos tienen limitaciones con `DrawToBitmap`. `RichTextBox` puede no reproducir su contenido completo; revisa las imagenes cuando uses controles de este tipo.
- `DrawToBitmap` no es una captura de pantalla del escritorio. Dibuja el control y sus hijos en una imagen.
- La opacidad se aplica a las capturas temporales. Los controles de usuario reales no tienen una propiedad de opacidad equivalente a la de un formulario.
- Libera los bitmaps con `Dispose()` cuando dejen de utilizarse. En el metodo de exportacion, `using` se encarga de hacerlo.
