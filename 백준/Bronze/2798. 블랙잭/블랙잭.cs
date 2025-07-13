int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = 0;
for (int i = 0; i < a[0] - 2; i++)
{
    for (int j = i + 1; j < a[0] - 1; j++)
    {
        for (int k = j + 1; k < a[0]; k++)
        {
            if (b[i] + b[j] + b[k] <= a[1] && b[i] + b[j] + b[k] > c)
                c = b[i] + b[j] + b[k];
        }
    }
}
Console.WriteLine(c);