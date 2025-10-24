 int a = int.Parse(Console.ReadLine());
 int[] b = new int[a + 1];
 for (int i = 1; i <= a; i++)
 {
     b[i] = int.Parse(Console.ReadLine());
 }

 if (a == 1)
 {
     Console.WriteLine(b[1]);
     return;
 }
 if (a == 2)
 {
     Console.WriteLine(b[1] + b[2]);
     return;
 }

 int[] c = new int[a + 1];
 c[1] = b[1];
 c[2] = b[1] + b[2];
 c[3] = Math.Max(b[1] + b[3], b[2] + b[3]);

 for (int i = 4; i <= a; i++)
     c[i] = Math.Max(c[i - 2] + b[i], c[i - 3] + b[i - 1] + b[i]);

 Console.WriteLine(c[a]);