int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long b = a[0];
long c = a[1];
int d = 1;

while (c > b)
{
    if (c % 10 == 1)
        c /= 10;
    else if (c % 2 == 0)
        c /= 2;
    else
        break;
    d++;
}

if (c == b)
    Console.WriteLine(d);
else
    Console.WriteLine(-1);