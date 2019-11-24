using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise354
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            double result = Read(x, y);
            Console.WriteLine(result);
        }

        static double Read(double x, double y)
        {
            Random random = new Random();
            return random.NextDouble() * (y - x) + x;
        }
    }
}
