 long[] a = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
 long[] b = new long[a[0]];
 for (int i = 0; i < a[0]; i++)
     b[i] = long.Parse(Console.ReadLine());

 long d = 1;
 long dd = b[0] * a[1];
 foreach (long bb in b)
     dd = Math.Max(dd, bb * a[1]);

 long c = dd;

 while (d <= dd)
 {
     long ddd = (d + dd) / 2;
     long cc = 0;

     for (int i = 0; i < a[0]; i++)
     {
         cc += ddd / b[i];

         if (cc >= a[1])
             break;
     }

     if (cc >= a[1])
     {
         c = ddd;
         dd = ddd - 1;
     }
     else
         d = ddd + 1;
 }

 Console.WriteLine(c);