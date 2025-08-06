int a = int.Parse(Console.ReadLine());
int[] b = new int[a + 1];
b[1] = 0;

for (int i = 2; i <= a; i++)
{
    b[i] = b[i - 1] + 1;

    if (i % 2 == 0)
        b[i] = Math.Min(b[i], b[i / 2] + 1);

    if (i % 3 == 0)
        b[i] = Math.Min(b[i], b[i / 3] + 1);
}
Console.WriteLine(b[a]);