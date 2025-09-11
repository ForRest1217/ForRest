int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = 0;
for (int i = 1; i <= a[0]; i++)
{
    if (a[0] % i == 0)
    {
        b++;
        if (b == a[1])
        {
            Console.WriteLine(i);
            return;
        }
    }
}
Console.WriteLine(0);