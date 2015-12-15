using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Arrays
    {
        public static void Main()
        {
            //string[] names = { "Peter", "Maria", "Katya", "Todor" };
            //names.Reverse();
            //names[0] = names[0] + " (junior)";
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //names[4] = "Nakov"; // This will cause an exception!
            //int[][] a = new int[5][];
            //var matrix = CreateMatrix(4);
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            int[] arr = { 4, 5, 2, 612, 3, 7, 9, 52, 6, 34 };
            //Array.Sort(arr);
            var a = Array.FindAll(arr, t => t % 2 == 0);
            //Console.WriteLine(a);
            //foreach (var item in a)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine();
            //Reorder(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine();
        }

        static void Reorder(int[] array)
        {
            int a = array[0];
            array[0] = array[array.Length - 1];
            array[array.Length - 1] = a;
        }

        static int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i + j + 1;
                }
            }
            return matrix;
        }
    }
}
