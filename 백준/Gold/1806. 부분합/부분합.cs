 int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
 int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 int c = 0;
 int cc = int.MaxValue;
 int d = 0;
 for (int i = 0; i < a[0]; i++)
 {
     d += b[i];

     while (d >= a[1])
     {
         cc = Math.Min(cc, i - c + 1);
         d -= b[c];
         c++;
     }
 }

 Console.WriteLine(cc == int.MaxValue ? 0 : cc);