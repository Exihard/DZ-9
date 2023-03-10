// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начальное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    NumSum(M, N, sum);
}

NumSum(M, N, 0);