using System;
using Estrategia;

namespace Calculadora_de_descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var calculadoraDescuentos = new CalculadoraDescuentos();

            Console.WriteLine("Ingrese el precio del producto");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("El precio total con el descuento por la primera compra de 10% es: ");
            calculadoraDescuentos.SetStrategy(new DescuentoPrimeraCompra());
            calculadoraDescuentos.DescuentoProducto(monto);

            Console.WriteLine();

            Console.WriteLine("El precio total con el descuento por ser cliente VIP de 15% es: ");
            calculadoraDescuentos.SetStrategy(new DescuentoVIP());
            calculadoraDescuentos.DescuentoProducto(monto);

            Console.WriteLine();

            Console.WriteLine("El precio total con el descuento por temporada de 5% es: ");
            calculadoraDescuentos.SetStrategy(new DescuentoTemporada());
            calculadoraDescuentos.DescuentoProducto(monto);
        }
    }
}