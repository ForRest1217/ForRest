using System.Text;
 internal class Program
 {
     static int a, b;
     static StringBuilder sb = new StringBuilder();

     static void Main()
     {
         int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
         a = aa[0];
         b = aa[1];

         int[] sequence = new int[b];
         A(1, 0, sequence);
         Console.Write(sb);
     }

     static void A(int a, int b, int[] c)
     {
         if (b == Program.b)
         {
             sb.AppendLine(string.Join(" ", c));
             return;
         }

         for (int i = a; i <= Program.a; i++)
         {
             c[b] = i;
             A(i + 1, b + 1, c);
         }
     }
 }