int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = new int[a[0]];
int c = 0;
for (int i = 0; i < a[0]; i++)
{
    b[i] = int.Parse(Console.ReadLine());
}


for (int i = a[0] - 1; i >= 0; i--)
{
    if (b[i] <= a[1])
    {
        c += a[1] / b[i]; 
        a[1] %= b[i];      
    }
}
Console.WriteLine(c);