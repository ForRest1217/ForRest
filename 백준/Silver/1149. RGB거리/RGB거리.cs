int a = int.Parse(Console.ReadLine()!);
int[,] b = new int[3, a];
int[,] c = new int[3, a];

for (int i = 0; i < a; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    for (int j = 0; j < 3; j++)
    {
        c[j, i] = aa[j];
    }
}

for (int i = 0; i < 3; i++)
    b[i, 0] = c[i, 0];

for (int i = 1; i < a; i++)
{
    b[0, i] = Math.Min(b[1, i - 1], b[2, i - 1]) + c[0, i];
    b[1, i] = Math.Min(b[0, i - 1], b[2, i - 1]) + c[1, i];
    b[2, i] = Math.Min(b[0, i - 1], b[1, i - 1]) + c[2, i];
}

int aaa = Math.Min(b[0, a - 1], Math.Min(b[1, a - 1], b[2, a - 1]));

Console.WriteLine(aaa);