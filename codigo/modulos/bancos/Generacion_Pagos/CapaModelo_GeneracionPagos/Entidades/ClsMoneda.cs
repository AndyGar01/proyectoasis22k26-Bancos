using System;

namespace CapaModelo_GeneracionPagos.Entidades
{
    public class ClsMoneda
    {
        public long PK_Moneda { get; set; }
        public string CodigoMoneda { get; set; }
        public string NombreMoneda { get; set; }
        public string SimboloMoneda { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}