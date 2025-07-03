int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}