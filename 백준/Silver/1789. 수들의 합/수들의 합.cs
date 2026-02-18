long a = long.Parse(Console.ReadLine());
long b = 0;
long c = 0;

while (true)
{
    c++;
    b += c;

    if (b > a)
    {
        c--;
        break;
    }
}

Console.WriteLine(c);