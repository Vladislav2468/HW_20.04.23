// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int maxi = 0;
if (a > b)
{
    maxi = a;
}
else
{
    maxi = b;
}
if (c > maxi)
{
    maxi = c;
}
Console.WriteLine(maxi);

