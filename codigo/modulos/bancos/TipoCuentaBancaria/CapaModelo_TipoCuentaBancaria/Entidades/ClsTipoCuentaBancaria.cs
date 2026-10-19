using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_TipoCuentaBancaria.Entidades
{
    public class ClsTipoCuentaBancaria
    {
        public long  IdTipoCuentaBancaria { get; set; }
        public string CodigoTipoCuentaBancaria { get; set; }
        public string NombreTipoCuentaBancaria { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
