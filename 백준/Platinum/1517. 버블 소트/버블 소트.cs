
internal class Program
{
    static long c = 0;

    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()!);
        int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        BubbleSort(b, 0, a - 1);

        Console.WriteLine(c);
    }

    private static void BubbleSort(int[] b, int d, int ddd)
    {
        if (d >= ddd)
            return;

        int dd = (d + ddd) / 2;

        BubbleSort(b, d, dd);
        BubbleSort(b, dd + 1, ddd);
        Merge(b, d, dd, ddd);
    }

    static void Merge(int[] b, int d, int dd, int ddd)
    {
        int[] temp = new int[ddd - d + 1];

        int e = d;
        int ee = dd + 1;
        int eee = 0;

        while (e <= dd && ee <= ddd)
        {
            if (b[e] <= b[ee])
            {
                temp[eee++] = b[e++];
            }
            else
            {
                temp[eee++] = b[ee++];
                c += (dd - e + 1);
            }
        }

        while (e <= dd)
            temp[eee++] = b[e++];

        while (ee <= ddd)
            temp[eee++] = b[ee++];

        for (int t = 0; t < temp.Length; t++)
            b[d + t] = temp[t];
    }
}
