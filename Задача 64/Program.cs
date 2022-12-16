// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите начальное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNum(N,1));
string PrintNum(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start + " " + PrintNum(start-1, end));
}