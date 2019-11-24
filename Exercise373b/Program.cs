using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise373b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            FillArray(array);
            PrintProduct(array);
        }

        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintProduct(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=10 && array[i] <= 20)
                {
                    product *= array[i];
                }
            }
            Console.WriteLine("Product= {0}", product);
        }
    }
}
