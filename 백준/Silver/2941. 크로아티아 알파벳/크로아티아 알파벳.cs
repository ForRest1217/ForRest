string a = Console.ReadLine();
int b = 0;
int c = 0;
while (b < a.Length)
{
    if (b + 2 < a.Length && a[b] == 'd' && a[b + 1] == 'z' && a[b + 2] == '=')
    {
        c++;
        b += 3;
        continue;
    }
    if (b + 1 < a.Length)
    {
        if ((a[b] == 'c' && (a[b + 1] == '=' || a[b + 1] == '-'))
            || (a[b] == 'd' && a[b + 1] == '-')
            || (a[b] == 'l' && a[b + 1] == 'j')
            || (a[b] == 'n' && a[b + 1] == 'j')
            || (a[b] == 's' && a[b + 1] == '=')
            || (a[b] == 'z' && a[b + 1] == '='))
        {
            c++;
            b += 2;
            continue;
        }
    }
    c++; b++;
}
Console.WriteLine(c);