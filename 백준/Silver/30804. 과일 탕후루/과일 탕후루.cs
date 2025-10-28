int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int c = 0;
int d = 0;
int e = 0;
int[] count = new int[10];


for (int i = 0; i < a[0]; i++)
{
    if (count[b[i]] == 0)
        c++;

    count[b[i]]++;

    while (c > 2)
    {
        count[b[d]]--;

        if (count[b[d]] == 0)
            c--;

        d++;
    }

    e = Math.Max(e, i - d + 1);
}

Console.WriteLine(e);