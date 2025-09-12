while (true)
{
    int a = int.Parse(Console.ReadLine());
    List<int> list = new List<int>();
    int b = 0;

    if (a == -1)
        break;

    for (int i = 1; i <= a / 2; i++)
    {
        if (a % i == 0) list.Add(i);
    }
    foreach (int listlist in list)
    {
        b += listlist;
    }

    if (b == a)
    {
        Console.Write($"{a} = ");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (i < list.Count - 1)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"{a} is NOT perfect.");
    }
}