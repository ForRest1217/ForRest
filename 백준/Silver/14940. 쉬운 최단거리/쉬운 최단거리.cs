using System.Text;

internal class Program
{
    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int[,] b = new int[a[0], a[1]];
        int[,] c = new int[a[0], a[1]];
        int d = 0, dd = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < a[0]; i++)
        {
            int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            for (int j = 0; j < a[1]; j++)
            {
                b[i, j] = aa[j];
                c[i, j] = -1;
                if (b[i, j] == 2)
                {
                    d = i;
                    dd = j;
                }
            }
        }

        Queue<(int x, int y)> q = new Queue<(int, int)>();
        int[] moveX = { -1, 1, 0, 0 };
        int[] moveY = { 0, 0, -1, 1 };

        q.Enqueue((d, dd));
        c[d, dd] = 0;

        while (q.Count > 0)
        {
            (int x, int y) = q.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int xValue = x + moveX[i];
                int yValue = y + moveY[i];

                if (xValue < 0 || yValue < 0 || xValue >= a[0] || yValue >= a[1])
                    continue;

                if (b[xValue, yValue] == 0)
                    continue;

                if (c[xValue, yValue] != -1)
                    continue;

                c[xValue, yValue] = c[x, y] + 1;
                q.Enqueue((xValue, yValue));
            }
        }

        for (int i = 0; i < a[0]; i++)
        {
            for (int j = 0; j < a[1]; j++)
            {
                if (b[i, j] == 0)
                    sb.Append("0 ");
                else
                    sb.Append(c[i, j] + " ");
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}