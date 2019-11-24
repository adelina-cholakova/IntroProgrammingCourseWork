using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise413
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Add numbers count:");
            int n = int.Parse(Console.ReadLine());

            double[] a = new double[n];
            FillArray(a);
            PrintArray(a);
            double averageA = GetAverage(a);

            double[] b = new double[n];
            FillArray(b);
            PrintArray(b);
            double averageB = GetAverage(b);

            double[] c = new double[n];
            FillArray(c);
            PrintArray(c);
            double averageC = GetAverage(c);

            Console.WriteLine("AverageA= {0}", averageA);
            Console.WriteLine("AverageB= {0}", averageB);
            Console.WriteLine("AverageC= {0}", averageC);

            double averageSquare = GetAverageSquare(new double[] { averageA, averageB, averageC });
            Console.WriteLine("AverageSquare = {0}", averageSquare);
        }
        static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void FillArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static double GetAverage(double[] array)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                    sum += array[i];
                }

            }
            return sum / count;

        }

        static double GetAverageSquare(double[] array)
        {
            double numerator = 0;
            for (int i = 0; i < array.Length; i++)
            {
                numerator += Math.Pow(array[i], 2);
            }
            return Math.Sqrt(numerator / array.Length);
        }
    }
}
