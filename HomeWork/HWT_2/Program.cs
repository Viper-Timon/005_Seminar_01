// ДЗ с семинара №1
// Задача 2: Напишите программу, которая вход 2 числа
// Выдает какое больше, а какое меньше
Console.Write("Введите первое число -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int num2 = int.Parse(Console.ReadLine());
bool comp = num1 == num2;
if(num1 > num2) 
{  
    Console.Write("Первое число -> ");
    Console.Write(num1);
    Console.Write(" больше чем второе число -> ");
    Console.WriteLine(num2);
}
else if (num1 < num2)  
{
    Console.Write("Второе число -> ");
    Console.Write(num2);
    Console.Write(" больше чем первое число -> ");
    Console.WriteLine(num1);
}
else if (comp = true)
{
    Console.Write("Первое число -> ");
    Console.Write(num2);
    Console.Write(" равно второму числу -> ");
    Console.WriteLine(num1);
}