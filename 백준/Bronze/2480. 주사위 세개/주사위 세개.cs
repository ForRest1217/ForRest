int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (a[0] == a[1] && a[1] == a[2])
{
    Console.WriteLine(10000 + a[0] * 1000);
}
else if (a[0] == a[1] || a[0] == a[2])
{
    Console.WriteLine(1000 + a[0] * 100);
}
else if (a[1] == a[2])
{
    Console.WriteLine(1000 + a[1] * 100);
}
else
{
    int max = Math.Max(a[0], Math.Max(a[1], a[2]));
    Console.WriteLine(max * 100);
}