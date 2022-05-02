Console.Write("Введите число -> "); // программа с вводом числа и выведением от -1*число до числа всех значений
int n = int.Parse(Console.ReadLine());
int i;
if (n<0) n = n * -1;
for (i = n*-1; i <= n; i++) 
{
    Console.Write(i);
    Console.Write(" ");
}