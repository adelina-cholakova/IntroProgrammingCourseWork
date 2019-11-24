using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());

            Console.Write("z=");
            double z = double.Parse(Console.ReadLine());

            double result = 0;
            if (y <= 0 && z >= 0)
            {
                result = Math.Pow(y, 2) + Math.Pow(z, 2) + 1;
            }
            else if (y > 0 && z < 0)
            {
                result = y * z + 1;
            }

            Console.WriteLine("Result= {0}", result);
        }
    }
}
