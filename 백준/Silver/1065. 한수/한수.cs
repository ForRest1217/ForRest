 int a = int.Parse(Console.ReadLine());
 int b = 0;
 if (a < 100)
 {
     Console.WriteLine(a);
     return;
 }

 b = 99;
 for (int i = 100; i <= a; i++)
 {
     int aa = i / 100;
     int bb = (i / 10) % 10;
     int cc = i % 10;

     if (aa - bb == bb - cc)
         b++;
 }
 Console.WriteLine(b);