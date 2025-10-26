 int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

 int b = a[0] * a[4] - a[1] * a[3];
 int c = (a[2] * a[4] - a[1] * a[5]) / b;
 int d = (a[0] * a[5] - a[2] * a[3]) / b;

 Console.WriteLine($"{c} {d}");