using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingresar t, a:");

            double t = double.Parse(Console.ReadLine()); // t = 3.61
            double a = double.Parse(Console.ReadLine()); // a = 33.69

            double y = t * Math.Sin(a * (Math.PI / 180));
            double z = t * Math.Cos(a * (Math.PI / 180));
            double b = Math.Asin((t * Math.Sin(a * (Math.PI / 180))) / y) * (180 / Math.PI); // ley de seno
            double c = Math.Asin((z * Math.Sin(b * (Math.PI / 180))) / t) * (180 / Math.PI); //ley de seno

            //aca tuve que convertir a b en radianes "Math.Sin(b*(Math.PI/180))"

            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
        }
    }
}
