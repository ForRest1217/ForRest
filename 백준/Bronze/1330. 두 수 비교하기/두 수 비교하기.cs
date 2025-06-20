int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (a[0] > a[1])
    Console.WriteLine(">");
else if (a[0] < a[1])
    Console.WriteLine("<");
else if (a[0] == a[1])
    Console.WriteLine("==");