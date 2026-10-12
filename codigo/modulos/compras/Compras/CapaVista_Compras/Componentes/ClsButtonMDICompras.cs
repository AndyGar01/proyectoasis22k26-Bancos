using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public class ClsButtonMDICompras : ClsButtonCompras
    {
        public ClsButtonMDICompras()
        {
            MinimumSize = Size.Empty;
            MaximumSize = Size.Empty;
            Size = new Size(352, 52);
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Cursor = Cursors.Default;
            FlatStyle = FlatStyle.Popup;
            FlatAppearance.BorderSize = 1;
            Font = new Font("Tahoma", 10F, FontStyle.Regular);
            TextAlign = ContentAlignment.MiddleLeft;    
        }

        protected override Size DefaultSize => new Size(352, 52);
    }
}
