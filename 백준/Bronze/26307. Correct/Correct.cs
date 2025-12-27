int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine((a[0] - 9) * 60 + a[1]);