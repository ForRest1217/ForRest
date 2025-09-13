   int a = int.Parse(Console.ReadLine());
   int[] b = new int[a];

   for (int i = 0; i < a; i++)
   {
       b[i] = int.Parse(Console.ReadLine());
   }

   Array.Sort(b);
   foreach (int c in b)
   {
       Console.WriteLine(c);
   }