int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int c = b[2] % b[0];
    int d = b[2] / b[0] + 1;
    if (c == 0)
    {
        c = b[0];
        d = b[2] / b[0];
    }
    Console.WriteLine($"{c}{d:D2}");
}