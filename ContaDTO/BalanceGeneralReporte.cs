using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilidadDTO
{
    public class BalanceGeneralReporte
    {
        public String Cuenta { get; set; }
        public String Descripcion { get; set; }
        public Double SaldoAnterior { get; set; }
        public Double Debe { get; set; }
        public Double Haber { get; set; }
        public Double SaldoActual { get; set; }
    }
}
