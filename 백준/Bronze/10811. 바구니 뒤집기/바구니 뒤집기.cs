int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = new int[a[0]];
for (int i = 0; i < a[0]; i++)
    b[i] = i + 1;

for (int i = 0; i < a[1]; i++)
{
    int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Array.Reverse(b, aa[0] - 1, aa[1] - aa[0] + 1);
}

Console.WriteLine(string.Join(" ", b));