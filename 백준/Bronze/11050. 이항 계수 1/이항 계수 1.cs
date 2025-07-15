int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = 1;
int c = 1;
int d = 1;
for (int i = 1; i <= a[0]; i++)
{
    b *= i;
}
for (int i = 1; i <= a[0] - a[1]; i++)
{
    c *= i;
}
for (int i = 1; i <= a[1]; i++)
{
    d *= i;
}
Console.WriteLine(b / (c * d));