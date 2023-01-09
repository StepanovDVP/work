Console.Clear();
int NumberGet(string text)
{   
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

Console.WriteLine("*** Задача 64 ***");
// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string NumbersRec(int N)
{
    if(N>=1) return $"{N} " + NumbersRec(N-1);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(NumberGet("Введите число N: ")));

Console.WriteLine("*** Задача 66 ***");
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumRec(int m, int n)
{
    if (m - 1 == n) return 0;
    else return n + SumRec(m, n - 1);
}

Console.WriteLine(SumRec(NumberGet("Введите число m: "), NumberGet("Введите число n: ")));

Console.WriteLine("*** Задача 68 ***");
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine(Ackermann(NumberGet("Введите число m: "), NumberGet("Введите число n: ")));
