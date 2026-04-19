int a = int.Parse(Console.ReadLine()!);

for(int i = 0; i < a; i++)
{
    int aa = int.Parse(Console.ReadLine());
    int[,] b = new int[2, aa];
    int[,] c = new int[2, aa];
    for (int j = 0;j < 2;j++)
    {
        int[] aaa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        for (int k = 0; k < aa; k++)
        {
            b[j, k] = aaa[k];
        }
    }

    c[0, 0] = b[0, 0];
    c[1, 0] = b[1, 0];
    if (aa > 1)
    {
        c[0, 1] = c[1, 0] + b[0, 1];
        c[1, 1] = c[0, 0] + b[1, 1];
    }

    for (int j = 2; j < aa;j++)
    {
        c[0, j] = Math.Max(c[1, j- 1], c[1, j- 2]) + b[0, j];
        c[1, j] = Math.Max(c[0, j - 1], c[0, j - 2]) + b[1, j];
    }

    Console.WriteLine(Math.Max(c[0, aa - 1], c[1, aa - 1]));
}