 int a = int.Parse(Console.ReadLine().Trim());
 int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

 for (int t = 0; t < a; t++)
 {
     int c = b[t];
     int d = 0;

     for (int i = 1; i * i <= c; i++)
     {
         if (c % i == 0)
         {
             int pair = c / i;

             if (i != c)
                 d += i;

             if (pair != i && pair != c)
                 d += pair;
         }
     }

     if (d == c)
         Console.WriteLine("Perfect");
     else if (d < c)
         Console.WriteLine("Deficient");
     else
         Console.WriteLine("Abundant");
 }