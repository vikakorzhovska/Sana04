using Task;

int[,] matr = Matrix.GenerateMatrix(5, 5);
MatrixConsole.PrintMatrix(matr);
int count = Matrix.CountPositiv(matr);
MatrixConsole.PrintCount(count);
int max = Matrix.MaxNumber(matr);
MatrixConsole.PrintMax(max);
int rows = Matrix.RowsWithoutZero(matr);
MatrixConsole.PrintRowsWithoutZero(rows);
int cols = Matrix.ColumnWithZero(matr, 5, 5); 
MatrixConsole.PrintColsWithZero(cols);
int longest = Matrix.RowWithLongestSeries(matr); 
MatrixConsole.PrintRowWithLongestSerie(longest);
int[] product = Matrix.ProductPositiv(matr);
MatrixConsole.PrintProduct(product);
int maxSum = Matrix.MaxSum(matr); 
MatrixConsole.PrintMaxSum(maxSum);