using Task;

int[,] matr = Matrix.GenerateMatrix(6, 6);
MatrixConsole.PrintMatrix(matr);
int count = Matrix.CountPositiv(matr);
MatrixConsole.PrintCount(count);