string[] a = Console.ReadLine().Split();
int b = int.MaxValue;

for (int i = 0; i <= a[1].Length - a[0].Length; i++)
{
    int c = 0;
    for (int j = 0; j < a[0].Length; j++)
    {
        if (a[0][j] != a[1][i + j])
            c++;
    }
    b = Math.Min(b, c);
}
Console.WriteLine(b);