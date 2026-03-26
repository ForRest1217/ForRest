using System.Text;
internal class Program
{
    static int a, b, c, d;
    static int[,] e;
    static bool[,] ee;

    static int[] moveX = { 1, -1, 0, 0 };
    static int[] moveY = { 0, 0, 1, -1 };

    static void Main()
    {
        a = int.Parse(Console.ReadLine()!);
        StringBuilder sb = new StringBuilder();

        while (a-- > 0)
        {
            int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            b = input[0];
            c = input[1];
            d = input[2];

            e = new int[b, c];
            ee = new bool[b, c];

            for (int i = 0; i < d; i++)
            {
                int[] pos = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                e[pos[0], pos[1]] = 1;
            }

            int aa = 0;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (e[i, j] == 1 && !ee[i, j])
                    {
                        DFS(i, j);
                        aa++;
                    }
                }
            }

            sb.AppendLine(aa.ToString());
        }

        Console.Write(sb.ToString());
    }

    static void DFS(int x, int y)
    {
        ee[x, y] = true;

        for (int i = 0; i < 4; i++)
        {
            int xValue = x + moveX[i];
            int yValue = y + moveY[i];

            if (xValue < 0 || yValue < 0 || xValue >= b || yValue >= c)
                continue;

            if (e[xValue, yValue] == 1 && !ee[xValue, yValue])
                DFS(xValue, yValue);
        }
    }
}