   int a = int.Parse(Console.ReadLine()!);
   int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

   int[] c = new int[a];
   int[] cc = new int[a];

   for (int i = 0; i < a; i++)
   {
       c[i] = 1;
       for (int j = 0; j < i; j++)
       {
           if (b[j] < b[i] && c[i] < c[j] + 1)
           {
               c[i] = c[j] + 1;
           }
       }
   }

   for (int i = a - 1; i >= 0; i--)
   {
       cc[i] = 1;
       for (int j = a - 1; j > i; j--)
       {
           if (b[j] < b[i] && cc[i] < cc[j] + 1)
           {
               cc[i] = cc[j] + 1;
           }
       }
   }

   int d = 0;
   for (int i = 0; i < a; i++)
   {
       d = Math.Max(d, c[i] + cc[i] - 1);
   }

   Console.WriteLine(d);