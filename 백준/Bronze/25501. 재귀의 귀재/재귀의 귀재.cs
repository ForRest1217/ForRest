 internal class Program
 {
     static void Main(string[] args)
     {
         int a = int.Parse(Console.ReadLine());

         for (int i = 0; i < a; i++)
         {
             string b = Console.ReadLine();
             int c = A(b);
             Console.WriteLine($"{c} {d}");
         }
     }

     static int d;

     static int A(string dd)
     {
         d = 0;
         return B(dd, 0, dd.Length - 1);
     }

     static int B(string dd, int ddd, int dddd)
     {
         d++;
         if (ddd >= dddd)
             return 1;
         else if (dd[ddd] != dd[dddd])
             return 0;
         else
             return B(dd, ddd + 1, dddd - 1);
     }
 }