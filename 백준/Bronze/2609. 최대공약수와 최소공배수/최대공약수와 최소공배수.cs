int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = 0;
int c = 0;
if (a[0] < a[1])
    b = a[0];
else
    b = a[1];
for(int i = 1; i <= b; i++) 
{
    if ((a[0] % i == 0) && (a[1] % i ==0))
    {
        c = i;
    }
}
Console.WriteLine(c);
Console.WriteLine(c * (a[0]/c) * (a[1]/c));