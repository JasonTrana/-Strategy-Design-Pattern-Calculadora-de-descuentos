using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public class DescuentoPrimeraCompra : IEstrategiaDescuento
    {
        public double CalcularDescuento(double monto)
        {
            double descuento = monto * .90;

            return descuento;
        }
    }
}
