using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir__ºc_a_ºF
{
    class ejercicio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la conversión que desea realizar");
            Console.WriteLine("1. ºC  a  ºF");
            Console.WriteLine("2. ºF  a  ºC");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Ingresa ºC");
                double c = Convert.ToDouble(Console.ReadLine());
                double f = (c * 9 / 5) + (32);
                Console.WriteLine(c + "ºC equivale a " + f + "ºF");
            }
            else
            {
                Console.WriteLine("Ingresa ºF");
                double f = Convert.ToDouble(Console.ReadLine());
                double c = (f - 32) * 5 / 9;
                Console.WriteLine(f + "ºF equivale  a " + c + "ºC");
            }
            Console.ReadLine();
        }
    }
}
