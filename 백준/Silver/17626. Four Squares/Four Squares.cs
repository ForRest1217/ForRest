int a = int.Parse(Console.ReadLine());
int[] b = new int[a + 1];
b[0] = 0;
for (int i = 1; i <= a; i++)
{
    b[i] = int.MaxValue;
    for (int j = 1; j * j <= i; j++)
    {
        b[i] = Math.Min(b[i], b[i - j * j] + 1);
    }
}
Console.WriteLine(b[a]);