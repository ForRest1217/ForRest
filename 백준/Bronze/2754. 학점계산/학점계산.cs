string a = Console.ReadLine();
double b = 0.0;

switch (a[0])
{
    case 'A':
        b = 4.0;
        break;
    case 'B':
        b = 3.0;
        break;
    case 'C':
        b = 2.0;
        break;
    case 'D':
        b = 1.0;
        break;
    case 'F':
        b = 0.0;
        break;
}

if (a.Length > 1)
{
    if (a[1] == '+')
        b += 0.3;
    else if (a[1] == '-')
        b -= 0.3;
}

Console.WriteLine(b.ToString("0.0"));