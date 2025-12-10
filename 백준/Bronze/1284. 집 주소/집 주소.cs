while (true)
{
    string a = Console.ReadLine();

    if (a == "0")
        break;

    int b = 2;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == '1')
            b += 2;
        else if (a[i] == '0')
            b += 4;
        else
            b += 3;

        if (i < a.Length - 1)
            b += 1;
    }

    Console.WriteLine(b);
}