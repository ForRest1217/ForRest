using System.Text;
 int a = int.Parse(Console.ReadLine());
 StringBuilder sb = new StringBuilder();

 for (int i = 0; i < a; i++)
 {
     int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
     var c = Math.Pow(b[3] - b[0], 2) + Math.Pow(b[4] - b[1], 2);
     var d = Math.Pow(b[2] + b[5], 2);
     var dd = Math.Pow(b[2] - b[5], 2);

     if (c == 0)
     {
         if (b[2] == b[5])
             sb.AppendLine("-1");
         else
             sb.AppendLine("0");
     }
     else if (c == d || c == dd)
     {
         sb.AppendLine("1");
     }
     else if (c < d && c > dd)
     {
         sb.AppendLine("2");
     }
     else
         sb.AppendLine("0");
 }

 Console.Write(sb.ToString());