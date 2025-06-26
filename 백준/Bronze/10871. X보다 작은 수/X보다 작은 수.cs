int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < a[0]; i++)
{
    if (b[i] < a[1])
    {
        Console.Write(b[i] + " ");
    }
}