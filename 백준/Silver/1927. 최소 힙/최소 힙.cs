 int a = int.Parse(Console.ReadLine());
 PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
 StringWriter sw = new StringWriter();

 for (int i = 0; i < a; i++)
 {
     int b = int.Parse(Console.ReadLine());
     if (b == 0)
         if (pq.Count == 0)
             sw.WriteLine(0);
         else
             sw.WriteLine(pq.Dequeue());
     else
         pq.Enqueue(b, b);
 }

 Console.Write(sw.ToString());