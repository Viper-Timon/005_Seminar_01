Console.Write("Введите число -> ");
int n = int.Parse(Console.ReadLine());
int i;
for (i = n*-1; i <= n; i++) 
{
    Console.Write(i);
    Console.Write(" ");
}