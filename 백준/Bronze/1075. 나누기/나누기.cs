int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

a = (a / 100) * 100;

for (int i = 0; i < 100; i++)
{
    if ((a + i) % b == 0)
    {
        Console.WriteLine(i.ToString("D2"));
        break;
    }
}