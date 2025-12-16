int a = int.Parse(Console.ReadLine());
long b = 0;

for (int i = 0; i < a; i++)
{
    long[] c = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
    for (int j = 0; j < a; j++)
    {
        b += c[j];
    }
}

Console.WriteLine(b);