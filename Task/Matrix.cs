using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    public class Matrix
    {
        public static int[,] GenerateMatrix(int rowCount, int columnCount, int minValue = -5, int maxValue = 10)
        {
        int[,] matrix = new int[rowCount, columnCount];
            Random random = new Random();
            for (int i = 0;i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(minValue, maxValue);
                    return matrix;
        }
      
        public static int CountPositiv(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > 0)
                        count++;
            }
            return count;
        }
        public static int MaxNumber(int[,] matrix)
        {
            int max = -11;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int number = matrix[i, j];
                    int repeat = CountRepeat(matrix, number);

                    if (repeat > 1 && number > max)
                    {
                        max = number;
                    }
                }
            }

            return max;
        }

        public static int CountRepeat(int[,] matrix, int element)
        {
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == element)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public static int RowsWithoutZero(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count1 = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count1++;
                    }
                }
                if(count1 == 0)
                    count++;
            }
            return count;
        }
        public static int ColumnWithZero(int[,] matrix, int rows, int cols)
        {
            int count = 0;
            for (int j = 0; j < cols; j++)
            {
                int count1 = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count1++;
                    }
                }
                if (count1 != 0)
                    count++;
            }
            return count;
        }
        public static int RowWithLongestSeries(int[,] matrix)
        { 
            int longest = 0;
            int rowWithLongestSeries = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 1;

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[i, j - 1])
                    {
                        count++;
                    }
                    
                }
                if (count > longest)
                {
                    longest = count;
                    rowWithLongestSeries = i;
                }
            }

            return rowWithLongestSeries;
        }
        public static int[] ProductPositiv(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int[] products = new int[rows];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                products[i] = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        products[i] = 0;
                        break;
                    }

                    products[i] *= matrix[i, j];
                }
            }
            return products;
        }
        public static int MaxSum(int[,] matrix)
        {
            int maxSum1 = -11;
            int maxSum2 = -11;
            int maxSum;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n - 1; i++)
            {
                int sum = 0;
                for (int j = 0; j + i + 1 < m; j++)
                {
                    sum += matrix[i + j + 1, j];
                }
                maxSum1 = Math.Max(maxSum1, sum);
            }

            for (int j = 1; j < m - 1; j++)
            {
                int sum = 0;
                for (int i = 0; i + j + 1 < n; i++)
                {
                    sum += matrix[i, i + j + 1];
                }
                maxSum2 = Math.Max(maxSum2, sum);
            }
            maxSum = Math.Max(maxSum1, maxSum2);
            return maxSum;
        }
    }
}
