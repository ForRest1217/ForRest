 int a = int.Parse(Console.ReadLine());
 PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

 for (int i = 0; i < a; i++)
 {
     int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
     foreach (int aaa in aa)
     {
         if (pq.Count < a)
         {
             pq.Enqueue(aaa, aaa);
         }
         else if (pq.Peek() < aaa)
         {
             pq.Dequeue();
             pq.Enqueue(aaa,aaa);
         }
     }
 }

 Console.WriteLine(pq.Peek());