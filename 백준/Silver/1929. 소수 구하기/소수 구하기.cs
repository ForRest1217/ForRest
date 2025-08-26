using System.Text;
 
 int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 StringBuilder sb = new StringBuilder();
 bool issosu = true;
 for (int i = a[0]; i <= a[1]; i++)
 {
     if (i < 2)
         continue;

     for (int j = 2; j * j <= i; j++)
     {
         if (i % j == 0)
         {
             issosu = false;
             break;
         }
     }
     if (issosu)
         sb.AppendLine(i.ToString());
     issosu = true;
 }
 Console.WriteLine(sb.ToString());