string a = Console.ReadLine();
int b = 0;

foreach (char c in a)
{
    if ("ABC".Contains(c))
        b += 3;
    else if ("DEF".Contains(c))
        b += 4;
    else if ("GHI".Contains(c))
        b += 5;
    else if ("JKL".Contains(c))
        b += 6;
    else if ("MNO".Contains(c))
        b += 7;
    else if ("PQRS".Contains(c))
        b += 8;
    else if ("TUV".Contains(c))
        b += 9;
    else if ("WXYZ".Contains(c))
        b += 10;
}

Console.WriteLine(b);