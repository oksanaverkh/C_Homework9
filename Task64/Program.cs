// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.Clear();
Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine());

if (n <= 0) Console.Write($"ERROR! Enter positive number");
if (n > 0)
{
    Console.Write($"N = {n}, even numbers are --> ");
    ShowNumbers(n);
}

int ShowNumbers(int number)
{
    if (number == 1) return 1;
    if (number % 2 == 0)
    {
        Console.Write($"{number} ");
    }
    return ShowNumbers(number - 1);
}



