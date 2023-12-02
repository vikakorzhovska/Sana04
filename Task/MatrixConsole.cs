using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class MatrixConsole
    {
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]}\t");
                Console.WriteLine();
            }
        }
        public static void PrintCount(int count)
        {
            Console.WriteLine("Number of positive elements");
            Console.WriteLine($"{count}");
        }
        public static void PrintMax(int max)
        {
            Console.WriteLine("Maximum number");
            Console.WriteLine($"{max}");
        }
        public static void PrintRowsWithoutZero(int count)
        {
            Console.WriteLine("Count of rows");
            Console.WriteLine($"{count}");
        }
        public static void PrintColsWithZero(int count)
        {
            Console.WriteLine("Count of cols");
            Console.WriteLine($"{count}");
        }
        public static void PrintRowWithLongestSerie(int rowWithLongest)
        {
            Console.WriteLine("Line number with longest series of identical elements");
            Console.WriteLine($"{rowWithLongest}");
        }
        public static int PrintProduct(int[] products)
        {
            Console.WriteLine("Product in rows without negative elements");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}: {products[i]}");
            }
            return 1; 
        }
    }
}
