int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = a[0] % a[1];
int c = 0;

for (int i = 0; i < a[2]; i++)
{
    b *= 10;
    c = b / a[1];
    b %= a[1];
}

Console.WriteLine(c);