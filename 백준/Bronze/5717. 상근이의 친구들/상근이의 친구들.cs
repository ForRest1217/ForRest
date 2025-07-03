int[] a = { 1, 1 };
while (a[0] != 0 && a[1] != 0)
{
    a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (a[0] != 0 && a[1] != 0)
        Console.WriteLine(a[0] + a[1]);
}