Console.Write("Введите 3 разных числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
if (A>B & A>C)
{
    Console.WriteLine("Большее число это: " + A);
}
else
{
    if (B>A & B>C)
    {
        Console.WriteLine("Большее число это: " + B);
    }
    else
    {
        Console.WriteLine("Большее число это: " + C);
    }
}