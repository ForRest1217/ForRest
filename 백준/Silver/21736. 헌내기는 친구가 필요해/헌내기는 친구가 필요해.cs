internal class Program
{
    static int a1 = 0, a2 = 0;
    static char[,] b;
    static bool[,] visited;
    static int[] moveX = { -1, 1, 0, 0 };
    static int[] moveY = { 0, 0, -1, 1 };


    private static void Main(string[] args)
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        a1 = a[0]; a2 = a[1];
        b = new char[a[0], a[1]];
        visited = new bool[a[0], a[1]];

        int x = 0, y = 0;
        for (int i = 0; i < a[0]; i++)
        {
            string aa = Console.ReadLine()!;
            for (int j = 0; j < a[1]; j++)
            {
                b[i, j] = aa[j];
                if (b[i, j] == 'I')
                {
                    x = i;
                    y = j;
                }
            }
        }

        int c = BFS(x, y);
        Console.WriteLine(c == 0 ? "TT" : c);
    }

    public static int BFS(int x, int y)
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((x, y));
        visited[x, y] = true;

        int count = 0;

        while (q.Count > 0)
        {
            var (cx, cy) = q.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = cx + moveX[i];
                int ny = cy + moveY[i];

                if (nx < 0 || ny < 0 || nx >= a1 || ny >= a2)
                    continue;

                if (visited[nx, ny] || b[nx, ny] == 'X')
                    continue;

                visited[nx, ny] = true;

                if (b[nx, ny] == 'P')
                    count++;

                q.Enqueue((nx, ny));
            }
        }

        return count;
    }
}