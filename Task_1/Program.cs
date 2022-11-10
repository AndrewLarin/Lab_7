using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            if (Square(x1, y1, z1) > Square(x2, y2, z2))
                Console.WriteLine("Площадь первого треугольника больше, чем второго");
            else if ((Square(x1, y1, z1) < Square(x2, y2, z2)))
                Console.WriteLine("Площадь первого треугольника меньше, чем второго");
            else
                Console.WriteLine("Площади треугольников равны");
        }
        static double Square(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

    }
}
