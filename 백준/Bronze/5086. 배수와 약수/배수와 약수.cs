while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (a[0] == 0 && a[1] == 0)
        break;
    if (a[1] % a[0] == 0)
        Console.WriteLine("factor");
    else if (a[0] % a[1] == 0)
        Console.WriteLine("multiple");
    else
        Console.WriteLine("neither");
}