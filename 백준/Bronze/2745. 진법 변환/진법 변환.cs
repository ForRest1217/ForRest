 string[] a = Console.ReadLine().Split();
 long b = 0;
 long c = 1;

 for (int i = a[0].Length - 1; i >= 0; i--)
 {
     char d = a[0][i];
     int value;

     if (char.IsDigit(d))
         value = d - '0';
     else
         value = d - 'A' + 10;

     b += value * c;
     c *= int.Parse(a[1]);
 }
 Console.WriteLine(b);