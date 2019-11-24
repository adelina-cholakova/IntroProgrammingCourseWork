using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetUserNumber(7);
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int result = GetKDigit(n, (7 - k) + 1);
            Console.WriteLine("The digit on position {0} is {1}!", k, result);
        }

        static int GetUserNumber(int length)
        {
            Console.Write("Write a {0}-digit number: ", length);
            string input = Console.ReadLine();
            int n;
            while (!int.TryParse(input, out n) || input.Length != length)
            {
                Console.WriteLine("Not a valid number, try again.");

                input = Console.ReadLine();
            }
            return n;
        }

        static int GetKDigit(int n, int k)
        {
            int divider = (int)(Math.Pow(10, k - 1));
            int result = (n / divider) % 10;
            return result;
        }         
    }
}
