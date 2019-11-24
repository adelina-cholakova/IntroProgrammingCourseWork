using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise373a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[70];
            FillArray(array);
            PrintArray(array);
        }

        static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 201);
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
