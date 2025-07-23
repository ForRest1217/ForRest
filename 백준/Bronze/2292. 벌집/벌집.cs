int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine(1);
    return;
}
int b = 1;
int c = 1;
while (c < a)
{
    c += 6 * b;
    b++;
}
Console.WriteLine(b);