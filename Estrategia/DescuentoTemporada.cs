using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public class DescuentoTemporada : IEstrategiaDescuento
    {
        public double CalcularDescuento(double monto)
        {
            double descuento = monto * .95;
            return descuento;
        }
    }
}
