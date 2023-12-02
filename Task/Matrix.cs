using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
