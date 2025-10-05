int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b;
Array.Sort(a);


if (a[0] + a[1] > a[2]) 
    b = a[0] + a[1] + a[2];
else 
    b = (a[0] + a[1]) * 2 - 1;

Console.WriteLine(b);