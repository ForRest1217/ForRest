 int a = int.Parse(Console.ReadLine()!);
 for (int i = 0; i < a; i++)
 {
     int[] aa = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

     int b = aa[0];
     int c = aa[1];

     while (c != 0)
     {
         int temp = b % c;
         b = c;
         c = temp;
     }

     Console.WriteLine(aa[0] * aa[1] / b);
 }