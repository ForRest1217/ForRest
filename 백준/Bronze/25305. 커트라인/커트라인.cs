int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(b, (x, y) => y.CompareTo(x));
Console.WriteLine(b[a[1] - 1]);