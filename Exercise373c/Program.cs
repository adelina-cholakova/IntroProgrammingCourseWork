using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise373c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(a) + Sum(b * c));
        }

        static int Sum(int k)
        {
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                int num = random.Next();
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
