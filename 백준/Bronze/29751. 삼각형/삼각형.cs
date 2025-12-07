int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
double b = a[0] * a[1] / 2.0;
Console.WriteLine("{0:F1}", b);