int a = int.Parse(Console.ReadLine());
int b = 0;
for (int i = 5; i <= a; i *= 5)
{
    b += a / i;
}
Console.WriteLine(b);