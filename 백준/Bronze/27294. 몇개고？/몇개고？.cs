int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (a[0] >= 12 && a[0] <= 16 && a[1] == 0)
    Console.WriteLine(320);
else
    Console.WriteLine(280);