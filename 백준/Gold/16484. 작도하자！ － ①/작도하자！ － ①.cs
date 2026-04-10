double[] a = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
double b = a[0] / 2 - a[1];
Console.WriteLine(b.ToString("F1"));