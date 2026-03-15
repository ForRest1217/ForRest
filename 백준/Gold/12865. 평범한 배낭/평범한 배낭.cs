int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[] b = new int[a[1] + 1];

for (int i = 0; i < a[0]; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    for (int j = a[1]; j >= aa[0]; j--)
    {
        b[j] = Math.Max(b[j], b[j - aa[0]] + aa[1]);
    }
}

Console.WriteLine(b[a[1]]);