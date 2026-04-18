int a = int.Parse(Console.ReadLine()!);
int[][] b = new int[a][];
int[][] c = new int[a][];

for (int i = 0; i < a; i++)
{
    b[i] = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    c[i] = new int[i + 1];
}

c[0][0] = b[0][0];

for (int i = 1; i < a; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (j == 0)
            c[i][j] = c[i - 1][j] + b[i][j];
        else if (j == i)
            c[i][j] = c[i - 1][j - 1] + b[i][j];
        else
            c[i][j] = Math.Max(c[i - 1][j - 1], c[i - 1][j]) + b[i][j];
    }
}

int d = 0;
for (int i = 0; i < a; i++)
    d = Math.Max(d, c[a - 1][i]);

Console.WriteLine(d);