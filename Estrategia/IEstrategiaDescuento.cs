using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public interface IEstrategiaDescuento
    {
        double CalcularDescuento(double monto);
    }
}
