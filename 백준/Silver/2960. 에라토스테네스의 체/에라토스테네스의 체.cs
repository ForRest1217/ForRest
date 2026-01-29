 int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 bool[] b = new bool[a[0] + 1];
 int c = 0;

 for (int i = 2; i <= a[0]; i++)
 {
     if (b[i])
         continue;

     for (int j = i; j <= a[0]; j += i)
     {
         if (!b[j])
         {
             b[j] = true;
             c++;

             if (c == a[1])
             {
                 Console.WriteLine(j);
                 return;
             }
         }
     }
 }