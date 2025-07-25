int a = int.Parse(Console.ReadLine());
int b = 0;

for (int i = Math.Max(1, a - 54); i < a; i++)
{
    int iii = i;
    for (int j = i; j > 0; j /= 10)
    {
        iii += j % 10;
    }
    if (iii == a)
    {
        b = i;
        break;
    }
}
Console.WriteLine(b);