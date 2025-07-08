while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Array.Sort(a);
    if (a[0] == 0 && a[1] == 0 && a[2] == 0)
        break;
    if (a[0] * a[0] + a[1] * a[1] == a[2] * a[2])
        Console.WriteLine("right");
    else
        Console.WriteLine("wrong");
}