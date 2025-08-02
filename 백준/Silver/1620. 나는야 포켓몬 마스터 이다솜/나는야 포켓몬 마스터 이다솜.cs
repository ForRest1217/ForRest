using System.Text;


var sr = new StreamReader(Console.OpenStandardInput());
 var a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

 var dicNumber = new Dictionary<string, int>();
 var dicName = new Dictionary<int, string>();

 for (int i = 1; i <= a[0]; i++)
 {
     var b = sr.ReadLine();
     dicNumber[b] = i;
     dicName[i] = b;
 }

 StringBuilder sb = new StringBuilder();
 for (int i = 0; i < a[1]; i++)
 {
     var c = sr.ReadLine();

     if (int.TryParse(c, out var d))
     {
         sb.AppendLine(dicName[d]);
     }
     else
     {
         sb.AppendLine(dicNumber[c].ToString());
     }
 }
 Console.Write(sb.ToString());