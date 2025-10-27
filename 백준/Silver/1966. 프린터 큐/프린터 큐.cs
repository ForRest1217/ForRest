 int a = int.Parse(Console.ReadLine());

 for (int i = 0; i < a; i++)
 {
     int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
     int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
     Queue<(int, int)> queue = new Queue<(int, int)>();

     for (int j = 0; j < b[0]; j++)
         queue.Enqueue((j, c[j]));


     int d = 0;
     while (queue.Count > 0)
     {
         var e = queue.Dequeue();

         if (queue.Any(x => x.Item2 > e.Item2))
         {
             queue.Enqueue(e);
         }
         else
         {
             d++;
             if (e.Item1 == b[1])
             {
                 Console.WriteLine(d);
                 break;
             }
         }
     }
 }