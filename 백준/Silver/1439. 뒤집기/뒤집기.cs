 string a = Console.ReadLine();

 int b = 0;
 int c = 0;

 if (a[0] == '0')
     b++;
 else
     c++;

 for (int i = 1; i < a.Length; i++)
 {
     if (a[i] != a[i - 1])
     {
         if (a[i] == '0')
             b++;
         else
             c++;
     }
 }

 Console.WriteLine(Math.Min(b, c));