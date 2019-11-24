using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise122z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("e= ");
            double e = double.Parse(Console.ReadLine());

            double y = 0;
            int n = 1;

            while (true)
            {
                double nominator = 1;
                for (int i = 1; i <= 2 * n - 1; i += 2)
                {
                    nominator *= i;
                }

                double denominator = 1;
                for (int i = 2; i <= 2 * n; i += 2)
                {
                    denominator *= i;
                }

                double member = (nominator / denominator) * (Math.Pow(x, n) / (2 * n));

                if (member < e)
                {
                    break;
                }

                y += member;
                n++;
            }

            Console.WriteLine("Sum = {0}", y);

            double expressionResult = Math.Log(2 * (1 - Math.Sqrt(1 - x)) / x);
            Console.WriteLine("Expression = {0}", expressionResult);

            Console.WriteLine("y > expression? {0}", y > expressionResult);
        }
    }
}
