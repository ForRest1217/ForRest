using System.Text;
 int a = int.Parse(Console.ReadLine());
 PriorityQueue<int, int> pQueue = new PriorityQueue<int, int>();
 StringBuilder sb = new StringBuilder();

 for (int i = 0; i < a; i++)
 {
     int b = int.Parse(Console.ReadLine());

     if (b == 0)
     {
         if (pQueue.Count == 0)
             sb.AppendLine("0");
         else
         {
             pQueue.TryDequeue(out int value, out int _);
             sb.AppendLine(value.ToString());
         }
     }
     else
     {
         pQueue.Enqueue(b, -b);
     }
 }

 Console.Write(sb.ToString());