int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = a[1]; i <= 100; i++)
{
    int b = a[0] - i * (i - 1) / 2;
    if (b < 0 || b % i != 0)
        continue;

    int c = b / i;
    for (int j = 0; j < i; j++)
        Console.Write(c + j + " ");

    return;
}

Console.WriteLine(-1);