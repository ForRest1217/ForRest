int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = 0;

while (a[1] != a[2])
{
    a[1] = (a[1] + 1) / 2;
    a[2] = (a[2] + 1) / 2;
    b++;

    if (b > a[0])
    {
        Console.WriteLine(-1);
        return;
    }
}

Console.WriteLine(b);