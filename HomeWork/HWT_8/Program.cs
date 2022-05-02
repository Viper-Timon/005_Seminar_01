// ДЗ с семинара №1
// Задача 8: Напишите программу,вход число N
// Выдает все чётные 1 to N
Console.Write("Введите число -> ");
int n = int.Parse(Console.ReadLine());
int i;
if (n < 0) 
{
    n = n * -1;
    Console.WriteLine("Вы ввели число меньше нуля, но мы умножили его на -1");
}
else if (n == 0) Console.WriteLine("Так дело не пойдет, введите число отличное от нуля и единицы");
else if (n == 1) Console.WriteLine("Так дело не пойдет, введите число отличное от нуля и единицы");
for (i = 1; i <= n; i++) 
{
    if (n == 0) break;
    if (n == 1) break;
    int div = i % 2;
    if (div == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}
if (n > 1) 
{
    Console.WriteLine();
    Console.Write("Чётные числа в диапазоне от 1 до ");
    Console.Write(n);
    Console.WriteLine();
}
