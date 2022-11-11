// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Enter number M: ");
int m = GetNumber();
Console.Write("Enter number N: ");
int n = GetNumber();

Console.Write($"M = {m}; N = {n} --> {SumBetweenNumbers(m, n)}");

int GetNumber()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumBetweenNumbers(int num1, int num2)
{
    if (num1 > num2) return 0;

    return num1 + SumBetweenNumbers(num1+1, num2);
}
