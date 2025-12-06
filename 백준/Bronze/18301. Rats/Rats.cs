long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long b = ((a[0] + 1) * (a[1] + 1)) / (a[2] + 1) - 1;
Console.WriteLine(b);