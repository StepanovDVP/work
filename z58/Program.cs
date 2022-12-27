Console.Clear();
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int EnterData(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int[,] GetMatrix(string text)
{
    Console.WriteLine(text);
    int[,] matrix = new int[EnterData("enter row: "), EnterData("enter coloumn: ")];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = GetMatrix("Введите размер матрицы A:");
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = GetMatrix("Введите размер матрицы B:");
PrintMatrix(matrixB);

int m = matrixA.GetLength(0); // строка 
int k = matrixB.GetLength(1);
int n = matrixB.GetLength(0);
int[,] matrixC = new int[m, k];


int[,] ResultMatrix (int[,] c, int[,] a, int[,] b, int m, int k, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            int sum = 0;
            for (int kk = 0; kk < n; kk++)
            {
                sum = sum + a[i,kk] * b[kk,j];
            }
            c[i, j] = sum;
        }
    }
    return c;
}
Console.WriteLine("Результирующая матрица будет:");

PrintMatrix(ResultMatrix(matrixC, matrixA, matrixB, m, k, n));