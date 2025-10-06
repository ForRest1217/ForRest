while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (a[0] == 0 && a[1] == 0 && a[2] == 0)
        break;

    if (a[0] + a[1] <= a[2] || a[0] + a[2] <= a[1] || a[1] + a[2] <= a[0])
    {
        Console.WriteLine("Invalid");
        continue;
    }

    if (a[0] == a[1] && a[1] == a[2])
        Console.WriteLine("Equilateral");
    else if (a[0] == a[1] || a[1] == a[2] || a[0] == a[2])
        Console.WriteLine("Isosceles");
    else
        Console.WriteLine("Scalene");
}