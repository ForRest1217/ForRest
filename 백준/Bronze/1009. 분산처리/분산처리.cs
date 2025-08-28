int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int c = 1;
    int d = b[0] % 10;
    int e = b[1] % 4;

    if (d == 0)
    {
        Console.WriteLine(10);
        continue;
    }

    if (e == 0)
        e = 4;

    for (int j = 0; j < e; j++)
    {
        c = (c * d) % 10;
    }

    Console.WriteLine(c);
}