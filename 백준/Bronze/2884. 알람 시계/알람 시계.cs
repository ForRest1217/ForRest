int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
a[1] -= 45;
if (a[1] < 0)
{
    a[0] -= 1;
    a[1] += 60;
}
if (a[0] < 0)
{
    a[0] += 24;
}
Console.WriteLine($"{a[0]} {a[1]}");