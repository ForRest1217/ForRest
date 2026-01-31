using System.Numerics;


 internal class Program
 {
     static void Main()
     {
         int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
         BigInteger b = Factorial(a[0]) / (Factorial(a[1]) * Factorial(a[0] - a[1]));
         Console.WriteLine(b);
     }

     static BigInteger Factorial(int factorial)
     {
         BigInteger c = 1;
         for (int i = 2; i <= factorial; i++)
             c *= i;
         return c;
     }
 }