using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_ppt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string linea;
            Console.Write("Ingrese cateto 1: ");
            linea = Console.ReadLine();
            a = double.Parse(linea);
            Console.Write("Ingrese cateto 2: ");
            linea = Console.ReadLine();
            b = double.Parse(linea);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine();
            Console.Write("El valor de la hipotenusa es: {0}", c);
            Console.ReadKey();
        }
    }
}
