 long a = long.Parse(Console.ReadLine());
 a %= 1500000;

 if (a == 0)
 {
     Console.WriteLine(0);
     return;
 }
 if (a == 1)
 {
     Console.WriteLine(1);
     return;
 }

 int b = 0;
 int c = 1;
 for (int i = 2; i <= a; i++)
 {
     int aa = (b + c) % 1000000;
     b = c;
     c = aa;
 }

 Console.WriteLine(c);