int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = a[1] - a[0];
int c = a[1];
while (c != 0)
{
    int d = b % c;
    b = c;
    c = d;
}
Console.WriteLine($"{(a[1] - a[0]) / b} {a[1] / b}");