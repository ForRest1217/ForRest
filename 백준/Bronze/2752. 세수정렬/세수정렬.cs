int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(a);
Console.WriteLine($"{a[0]} {a[1]} {a[2]}");