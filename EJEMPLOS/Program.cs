using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            string linea;
            
            //Mayor de edad (ejemplo con "<")

            Console.Write("Ingresar su edad: ");
            linea = Console.ReadLine();
            a=int.Parse(linea);

            if (a < 18)
            {
                Console.WriteLine("Usted es menor de edad");
            }
            else
            {
                Console.WriteLine("Usted es mayor de edad");
            }

            Console.WriteLine("--------------------------------------------");

            //Edad de Jubilación (ejemplo con ">")

            Console.Write("Ingresar edad: ");
            linea=Console.ReadLine();
            a = int.Parse(linea);

            if (a > 64)
            {
                Console.WriteLine("Esta en edad de jubilacion");
            }
            else
            {
                a = 65 - a;
                Console.WriteLine("Le faltan " + a + " años para jubilarse");
            }

            Console.WriteLine("--------------------------------------------");

            //Bono por ventas (ejemplo con "<=")

            Console.WriteLine("BONO DE VENTAS");
            Console.WriteLine("LISTA DE BONOS:");
            Console.WriteLine("2-5 VENTAS: 200");
            Console.WriteLine("6-10 VENTAS: 500");
            Console.WriteLine("11 A MAS: 750");

            Console.Write("Ingresar cantidad de ventas: ");
            linea= Console.ReadLine();
            a = int.Parse(linea);

            int bono;
            if(1<a && a <= 5)
            {
                bono = 200;
                Console.WriteLine("Su bono es de: " + bono);
            }
            if (5 < a && a <= 10)
            {
                bono = 500;
                Console.WriteLine("Su bono es de: " + bono);
            }
            if (11 <= a)
            {
                bono = 750;
                Console.WriteLine("su bono es de: " + bono);
            }

            Console.WriteLine("--------------------------------------------");

            //Numeros Positivos o Negativos (ejemplo con ">=")

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            a = int.Parse(linea);

            if (a >= 1)
            {
                Console.WriteLine("El numero es positivo");
            }
            else {
                Console.WriteLine("El numero es negativo");
            }

            Console.WriteLine("--------------------------------------------");

            //DNI  (ejemplo con "!=")

            Console.Write("Ingrese su numero de DNI (solo tendra un intento): ");
            linea=Console.ReadLine();
            a = int.Parse(linea);
               //DNI = 10024389
            if (a != 10024389)
            {
                Console.WriteLine("ERROR!!");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("IDENTIDAD CONFIRMADA");
            }

            // INICIO DE SESION (Ejemplo "==")
            string usuario, contraseña;
            Console.Write("Nombre de Usuario: ");
            usuario = Console.ReadLine();

            Console.Write("Ingrese contraseña: ");
            contraseña = Console.ReadLine();

            if (usuario == "UPN" && contraseña == "123")
            {
                Console.WriteLine("Logró iniciar sesión");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
