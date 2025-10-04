int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int b = Math.Min(Math.Min(a[0], a[1]), Math.Min(a[2] - a[0], a[3] - a[1]));
Console.WriteLine(b);