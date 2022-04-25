Console.Write("Введите первое число -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int num2 = int.Parse(Console.ReadLine());
int num2res = num2 * num2; 
if(num1 == num2res)
{
        Console.Write("Квадрат второго числа = ");
        Console.Write(num2res);
        Console.Write(" и равен первому числу");
}
else
{
    Console.Write("Квадрат второго числа не равен первому");
}