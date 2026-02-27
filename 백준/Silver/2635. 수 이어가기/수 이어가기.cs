 int a = int.Parse(Console.ReadLine());
 List<int> list = new List<int>();
 int b = 0;
 for (int i = 0; i <= a; i++)
 {
     List<int> listwo = new List<int>();
     listwo.Add(a);
     listwo.Add(i);

     int bb = 0;
     int bbb = i;
     int bbbb = a;
     while (true)
     {
         bb = bbbb - bbb;

         if (bb < 0)
             break;

         listwo.Add(bb);

         bbbb = bbb;
         bbb = bb;
     }

     if (b < listwo.Count)
     {
         b = listwo.Count;
         list = new List<int>(listwo);
     }
 }
 Console.WriteLine(b);
 Console.WriteLine(string.Join(" ", list));