using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pro, uni;
            double precio, unid, subtotal;

            Console.Write("Ingrese el precio del producto: ");
            pro = Console.ReadLine();
            precio = double.Parse(pro);
            Console.WriteLine();
            Console.Write("Ingrese la cantidad de unidades del producto: ");
            uni = Console.ReadLine();
            unid = double.Parse(uni);
            Console.WriteLine();
            subtotal = precio * unid;
            Console.WriteLine("El subtotal es de: "+subtotal+"$");
            Console.WriteLine();

            if (subtotal > 100)
            {
                Console.WriteLine("Se le aplicará un descuento del 15%");
                double descuento;
                descuento = (subtotal * 5) / 100;
                Console.WriteLine("Descuento total: "+descuento+"$");
                Console.WriteLine();
                double preciofinal;
                preciofinal = subtotal - descuento;
                Console.WriteLine("El precio final es de: "+preciofinal+"$");

            }
            else
            {
                {
                    Console.WriteLine("El precio final es de:"+subtotal+"$");
                }
            }
        }
    }
}
