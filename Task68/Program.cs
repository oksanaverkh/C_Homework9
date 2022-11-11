// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Enter number M: ");
int m = GetNumber();
Console.Write("Enter number N: ");
int n = GetNumber();
Console.WriteLine();

if (m < 0 || n < 0) Console.Write($"ERROR! Enter positive numbers");
if (m > 0 || n > 0) Console.Write($"m = {m}; n = {n} --> A(m,n) = {Akkerman(m, n)}");

int GetNumber()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Akkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num1 != 0 && num2 == 0) return Akkerman(num1 - 1, 1);
    if (num1 > 0 && num2 > 0) return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
    return Akkerman(num1, num2);
}
