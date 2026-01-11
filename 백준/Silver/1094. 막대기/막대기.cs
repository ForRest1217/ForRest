int a = int.Parse(Console.ReadLine());
int b = 0;

while (a > 0)
{
    if ((a & 1) == 1)
        b++;

    a >>= 1;
}

Console.WriteLine(b);