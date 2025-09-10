   int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
   int[,] b = new int[a[0], a[1]];
   int[,] c = new int[a[0], a[1]];
   for (int i = 0; i < a[0]; i++)
   {
       int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
       for (int j = 0; j < a[1]; j++)
       {
           b[i, j] = aa[j];
       }
   }
   for (int i = 0; i < a[0]; i++)
   {
       int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
       for (int j = 0; j < a[1]; j++)
       {
           c[i, j] = aa[j];
       }
   }
   for (int i = 0; i < a[0]; i++)
   {
       for (int j = 0; j < a[1]; j++)
       {
           Console.Write($"{b[i, j] + c[i, j]} ");
       }
       Console.WriteLine();
   }