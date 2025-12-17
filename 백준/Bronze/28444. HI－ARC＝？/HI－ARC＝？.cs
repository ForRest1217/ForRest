int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int aa = a[0] * a[1];
int aaa = a[2] * a[3] * a[4];
Console.WriteLine(aa - aaa);