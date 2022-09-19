/* 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Например:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }
}

else if (b > c)
{
    Console.WriteLine("Максимальное число: " + b);
}
else
{
    Console.WriteLine("Максимальное число: " + c);
}