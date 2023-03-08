Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int x = 1;x<=N;x++)
{
    if (x%2==0)
    Console.Write($"{x} ");
}