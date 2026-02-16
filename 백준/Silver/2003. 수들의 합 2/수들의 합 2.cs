int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int c = 0;
int d = 0;
int e = 0;
int ee = 0;
while (true)
{
    if (d >= a[1])
    {
        d -= b[e++];
    }
    else if (ee == a[0])
    {
        break;
    }
    else
    {
        d += b[ee++];
    }

    if (d == a[1])
    {
        c++;
    }
}

Console.WriteLine(c);