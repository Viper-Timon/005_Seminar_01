// ДЗ с семинара №1
// Задача 6: Напишите программу,вход 1 число
// Выдает четное ли число
Console.Write("Введите число -> ");
int num1 = int.Parse(Console.ReadLine());
int res = num1 % 2;
if (res == 0)
{
    Console.Write("Введенное число -> ");
    Console.Write(num1);
    Console.WriteLine(" чётное");
}
else
{
    Console.Write("Введенное число -> ");
    Console.Write(num1);
    Console.WriteLine(" нечётное");   
}
