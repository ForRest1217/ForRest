int a = int.Parse(Console.ReadLine());
int b = 0;

while (a >= 0)
{
    if (a % 5 == 0)
    {
        b += a / 5;
        Console.WriteLine(b);
        return;
    }

    a -= 3;
    b++;
}

Console.WriteLine(-1);