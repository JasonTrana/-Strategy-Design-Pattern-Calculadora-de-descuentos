using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
        public class CalculadoraDescuentos
        {
            private IEstrategiaDescuento _strategy;

            public CalculadoraDescuentos()
            { }


            public CalculadoraDescuentos(IEstrategiaDescuento strategy)
            {
                this._strategy = strategy;
            }

            public void SetStrategy(IEstrategiaDescuento strategy)
            {
                this._strategy = strategy;
            }

            public void DescuentoProducto(double monto)
            {
                var PrecioFinal = this._strategy.CalcularDescuento(monto);

                Console.WriteLine(PrecioFinal.ToString());
            }
        }
    }
