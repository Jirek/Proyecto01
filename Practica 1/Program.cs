using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = false;
            string cadena = string.Empty;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("el valor de i es : {0}", i);
            Console.WriteLine("el valor de x es : {0:C}", x);
            Console.WriteLine("el valor de bandera es : "+bandera.ToString());
            Console.WriteLine("el valor de cadena es :"+ cadena);
            Console.WriteLine("el valor de fecha : " + fecha.ToShortDateString());
            

        }
    }
}
