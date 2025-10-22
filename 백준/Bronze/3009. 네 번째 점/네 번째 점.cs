int[] a = new int[3];
int[] b = new int[3];

for (int i = 0; i < 3; i++)
{
    int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    a[i] = c[0];
    b[i] = c[1];
}

int d = a[0] == a[1] ? a[2] : (a[0] == a[2] ? a[1] : a[0]);
int e = b[0] == b[1] ? b[2] : (b[0] == b[2] ? b[1] : b[0]);
Console.WriteLine($"{d} {e}");