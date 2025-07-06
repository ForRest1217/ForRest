int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = (int)Math.Ceiling((double)(a[2] - a[0]) / (a[0] - a[1])) + 1;
Console.WriteLine(b);