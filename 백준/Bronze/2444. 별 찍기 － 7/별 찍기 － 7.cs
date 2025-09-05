 int a = int.Parse(Console.ReadLine());

 for (int i = 1; i <= a; i++)
 {
     for (int j = 0; j < a - i; j++)
         Console.Write(" ");
     for (int j = 0; j < 2 * i - 1; j++)
         Console.Write("*");
     Console.WriteLine();
 }

 for (int i = a - 1; i >= 1; i--)
 {
     for (int j = 0; j < a - i; j++)
         Console.Write(" ");
     for (int j = 0; j < 2 * i - 1; j++)
         Console.Write("*");
     Console.WriteLine();
 }