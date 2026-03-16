using System.Text;
 

  int a = int.Parse(Console.ReadLine()!);

   PriorityQueue<int, int> queue1 = new PriorityQueue<int, int>();
   PriorityQueue<int, int> queue2 = new PriorityQueue<int, int>();

   StringBuilder sb = new StringBuilder();

   for (int i = 0; i < a; i++)
   {
       int aa = int.Parse(Console.ReadLine()!);

       if (queue1.Count == queue2.Count)
           queue1.Enqueue(aa, -aa);
       else
           queue2.Enqueue(aa, aa);

       if (queue2.Count > 0 && queue1.Peek() > queue2.Peek())
       {
           int b = queue1.Dequeue();
           int bb = queue2.Dequeue();

           queue1.Enqueue(bb, -bb);
           queue2.Enqueue(b, b);
       }

       sb.AppendLine(queue1.Peek().ToString());
   }

   Console.Write(sb.ToString());