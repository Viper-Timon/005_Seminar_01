// Напишите прог., которая на вход принимает число
// и выдает его квадрат (само на себя)
Console.Write("Введите число, чтобы возвести в квадрат -> ");
int num = int.Parse(Console.ReadLine());
int numResult = num * num;
Console.Write("Квадрат числа равен = ");
Console.WriteLine(numResult);
Console.ReadKey();