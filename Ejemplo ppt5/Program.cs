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
            int NUM1;
            string linea;
            long RESUL;
            Console.Write("Digite un número :");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = Math.Abs(NUM1);
            Console.WriteLine();
            Console.WriteLine("Valor absoluto : " + RESUL);
            Console.WriteLine("Potencia : " + Math.Pow(NUM1, 5));
            Console.WriteLine("Raíz cuadrada : " + Math.Sqrt(NUM1));
            Console.WriteLine("Núm. máximo : " + Math.Max(NUM1, 55));
            Console.WriteLine("Núm. mínimo : " + Math.Min(NUM1, 55));
            Console.WriteLine("Parte entera : " +
            Math.Truncate(19.88));
            Console.WriteLine("Redondeo : " + Math.Round(19.88));
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
