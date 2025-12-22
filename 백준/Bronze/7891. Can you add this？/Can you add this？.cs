 int a = int.Parse(Console.ReadLine());
 for (int i = 0; i < a; i++)
 {
     int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
     Console.WriteLine(b[0] + b[1]);
 }