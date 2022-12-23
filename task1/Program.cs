Console.Clear();
Console.WriteLine("*** Задача 47 ***");
// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
int GetNumber(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

double[,] GetArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
    return arr;
}

void PrintArr(double[,] arr)
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

Console.WriteLine("Введите размер массива m x n");

double[,] arr = new double[GetNumber("m: "), GetNumber("n: ")];
PrintArr(GetArray(arr));

Console.WriteLine();
Console.WriteLine("*** Задача 50 ***");
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
void SearchPosition(double[,] arr, int x, int y)
{
    bool position = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.WriteLine($"Число с позицией x = {x}, y = {y}: {arr[i, j]}");
                position = true;
            }
        }
    }
    if (position == false) Console.WriteLine($"x = {x}, y = {y}-> такого числа в массиве нет");
}
Console.WriteLine("Введите позиции (x, y) элемента в двумерном массиве (m x n)");
SearchPosition(arr, GetNumber("x: "), GetNumber("y: "));
Console.WriteLine();
Console.WriteLine("*** Задача 52 ***");
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetIntArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
int[,] intArr = new int[GetNumber("column: "), GetNumber("row: ")];
void PrintIntArr(int[,] arr)
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
List<double> ArithmeticMean(int[,] arr)
{
    var someList = new List<double>();

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        someList.Add(Math.Round(sum / Convert.ToDouble(arr.GetLength(0)), 1));

    }
    return someList;
}
PrintIntArr(GetIntArray(intArr));
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", ArithmeticMean(intArr))}");


