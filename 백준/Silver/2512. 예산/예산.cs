 int a = int.Parse(Console.ReadLine());
 int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
 int aaa = int.Parse(Console.ReadLine());

 if (aa.Sum() <= aaa)
 {
     Console.WriteLine(aa.Max());
     return;
 }

 int b = 0;
 int bb = aa.Max();
 int c = 0;

 while (b <= bb)
 {
     int d = (b + bb) / 2;
     long dd = 0;

     foreach (int aaaa in aa)
     {
         dd += Math.Min(aaaa, d);
     }

     if (dd <= aaa)
     {
         c = d;    
         b = d + 1;
     }
     else
     {
         bb = d - 1;  
     }
 }

 Console.WriteLine(c);