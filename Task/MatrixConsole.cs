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
            Console.WriteLine("Кількість додатних елементів");
            Console.WriteLine($"{count}");
        }
        public static void PrintMax(int max)
        {
            Console.WriteLine("Максимальне із чисел, що зустрічається в заданій матриці більше одного разу");
            Console.WriteLine($"{max}");
        }
        public static void PrintRowsWithoutZero(int count)
        {
            Console.WriteLine("Кількість рядків, які не містять жодного нульового елемента");
            Console.WriteLine($"{count}");
        }
        public static void PrintColsWithZero(int count)
        {
            Console.WriteLine("Кількість стовпців, які містять хоча б один нульовий елемент");
            Console.WriteLine($"{count}");
        }
        public static void PrintRowWithLongestSerie(int rowWithLongest)
        {
            Console.WriteLine("Номер рядка, в якому знаходиться найдовша серія однакових елементів");
            Console.WriteLine($"{rowWithLongest}");
        }
        public static int PrintProduct(int[] products)
        {
            Console.WriteLine("Добуток елементів в тих рядках, які не містять від’ємних елементів");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}: {products[i]}");
            }
            return 1; 
        }
        public static void PrintMaxSum(int maxSum)
        {
            Console.WriteLine("Максимум серед сум елементів діагоналей, паралельних головній діагоналі матриці");
            Console.WriteLine($"{maxSum}");
        }
        public static int PrintSumCols(int[] sum)
        {
            Console.WriteLine("Сума елементів в тих стовпцях, які не містять від’ємних елементів");
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}: {sum[i]}");
            }
            return 1;
        }
        public static void PrintMinSum(int minSum)
        {
            Console.WriteLine("Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці");
            Console.WriteLine($"{minSum}");
        }
    }
}
