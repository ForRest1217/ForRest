   int a = int.Parse(Console.ReadLine());
   int b = int.Parse(Console.ReadLine());
   List<int> list = new List<int>();
   int c = 0;

   for (int i = a; i <= b; i++)
   {
       if (i < 2)
           continue;

       bool isit = true;
       for (int j = 2; j * j <= i; j++)
       {
           if (i % j == 0)
           {
               isit = false;
               break;
           }
       }

       if (isit)
       {
           list.Add(i);
           c += i;
       }
   }

   if (list.Count == 0)
   {
       Console.WriteLine("-1");
   }
   else
   {
       Console.WriteLine(c);
       Console.WriteLine(list[0]);
   }