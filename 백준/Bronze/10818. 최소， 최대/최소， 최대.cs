int a = int.Parse(Console.ReadLine());
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int min = b[0];
int max = b[0];
for (int i = 0; i < a; i++)
{
    if (b[i] < min)
    {
        min = b[i];
    }
    if (b[i] > max)
    {
        max = b[i];
    }
}
Console.WriteLine($"{min} {max}");