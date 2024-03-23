using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public class DescuentoVIP : IEstrategiaDescuento
    {
        public double CalcularDescuento(double monto)
        {
            double descuento = monto * .85;
            return descuento;
        }
    }
}
