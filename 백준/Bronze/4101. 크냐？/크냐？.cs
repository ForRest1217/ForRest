while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (a[0] == 0 && a[1] == 0)
        break;
    if (a[0] > a[1])
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}