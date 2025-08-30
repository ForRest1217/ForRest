int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] b = new int[a[0]];

for (int i = 0; i < a[1]; i++)
{
    int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = c[0] -1; j <= c[1] -1; j++)
    {
        b[j] = c[2];
    }
}

for(int i = 0; i < b.Length; i++)
{
    Console.Write(b[i]);
    if(i != b.Length - 1)
        Console.Write(" ");
}