using Task;

int[,] matr = Matrix.GenerateMatrix(5, 5);
MatrixConsole.PrintMatrix(matr);
int count = Matrix.CountPositiv(matr);
MatrixConsole.PrintCount(count);
int max = Matrix.MaxNumber(matr);
MatrixConsole.PrintMax(max);