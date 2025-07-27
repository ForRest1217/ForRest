while (true)
{
    var a = Console.ReadLine();
    if (a == "0")
        break;
    int b;
    for (b = 0; b < a.Length / 2; b++)
    {
        if (a[b] != a[a.Length - b - 1])
        {
            Console.WriteLine("no");
            break;
        }
    }
    if (b == a.Length / 2)
    {
        Console.WriteLine("yes");
    }
}