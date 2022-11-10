using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Cube(a);
        }
        static void Cube(double a)
        {
            double v = a * a * a;
            double s = 6 * a * a;
            Console.WriteLine("Площадь поверности куба: {0}", s);
            Console.WriteLine("Объем куба: {0}", v);

        }
    }
}
