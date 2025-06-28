int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
float b = 0;
for (int i = 0; i < a.Length; i++)
{
    b += a[i] * a[i];
}
b %= 10;
double c = Math.Truncate(b);
Console.WriteLine(c);