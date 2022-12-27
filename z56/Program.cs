Console.Clear();
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetSize(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int[,] GetArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }

}

void GetMinSumm(int[,] arr)
{
    int indexMin = 0;
    int index = 0;
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)  sum = sum + arr[i,j];
        if (i == 0) res = sum;
        if (sum < res)
        {
            res = sum;
            indexMin = index;
        }
        index++;
    }    Console.WriteLine($"номер строки c наименьшей суммой ({res}) элементов: {indexMin} строка");
}


int[,] arr = new int[GetSize("кол-во строк: "), GetSize("кол-во столбцов: ")];
PrintArr(GetArr(arr));
GetMinSumm(arr);