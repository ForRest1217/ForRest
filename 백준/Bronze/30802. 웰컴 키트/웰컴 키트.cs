 int a = int.Parse(Console.ReadLine());
 int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 int d = 0;
 for (int i = 0; i < 6; i++)
 {
     d += (b[i] + c[0] - 1) / c[0];
 }
 Console.WriteLine(d);
 Console.WriteLine($"{a / c[1]} {a % c[1]}");