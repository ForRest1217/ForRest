 using System.Text;

int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
 List<int> list = new List<int>();
 int b = 0;
 StringBuilder sb = new StringBuilder();
 for (int i = 1; i <= a[0]; i++)
 {
     list.Add(i);
 }

 sb.Append("<");
 while(list.Count > 0)
 {
     b = (b + a[1] - 1) % list.Count; 
     sb.Append(list[b]);
     list.RemoveAt(b);

     if (list.Count > 0)
         sb.Append(", ");
 }
 sb.Append(">");
 Console.WriteLine(sb.ToString());