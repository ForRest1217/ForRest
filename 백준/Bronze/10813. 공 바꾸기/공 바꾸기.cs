int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = new int[a[0]];

for (int i = 0; i < a[0]; i++)
{
    b[i] = i + 1;
}

for (int i = 0; i < a[1]; i++)
{
    int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int cc = c[0] - 1;
    int ccc = c[1] - 1;

    int d = b[cc];
    b[cc] = b[ccc];
    b[ccc] = d;
}

for (int i = 0; i < b.Length; i++)
{
    Console.Write(b[i]);
    if (i != b.Length - 1)
        Console.Write(" ");
}