 int a = int.Parse(Console.ReadLine());
 int[] b = new int[26];
 for (int i = 0; i < a; i++)
 {
     string c = Console.ReadLine();
     char d = c[0];
     b[d - 'a']++;
 }

 bool isit = false;
 for (int i = 0; i < 26; i++)
 {
     if (b[i] >= 5)
     {
         Console.Write((char)(i + 'a'));
         isit = true;
     }
 }

 if (!isit)
 {
     Console.WriteLine("PREDAJA");
 }