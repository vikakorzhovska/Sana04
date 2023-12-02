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
        public static int[,] GenerateMatrix(int rowCount, int columnCount, int minValue = -10, int maxValue = 10)
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
    }
}
