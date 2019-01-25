using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingresar c, z:");

            double c = double.Parse(Console.ReadLine()); // c = 56.31
            double z = double.Parse(Console.ReadLine()); // z = 3

            double t = z / Math.Sin(c * (Math.PI / 180));
            double y = t * Math.Cos(c * (Math.PI / 180));
            double b = Math.Asin((t * Math.Sin(c * (Math.PI / 180))) / z) * (180 / Math.PI); // ley de seno y tranformacion a grados
            double a = Math.Asin((y * Math.Sin(b * (Math.PI / 180))) / t) * (180 / Math.PI); // ley de seno y tranformacion a grados

            Console.WriteLine("t=" + t);
            Console.WriteLine("y=" + y);
            Console.WriteLine("b=" + b);
            Console.WriteLine("a=" + a);
        }
    }
}
