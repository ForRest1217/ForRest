int a = int.Parse(Console.ReadLine());
long[] b = new long[a + 1];
b[0] = 1;

for (int i = 1; i <= a; i++)
{
    for (int j = 0; j < i; j++)
    {
        b[i] += b[j] * b[i - 1 - j];
    }
}

Console.WriteLine(b[a]);