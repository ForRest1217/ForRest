  int a = int.Parse(Console.ReadLine());
  int chong = 0;

  for (int i = 0; i < a; i++)
  {
      string aa = Console.ReadLine();

      HashSet<char> hash = new HashSet<char>();
      char b = '\0';
      bool isit = true;

      foreach (char aaa in aa)
      {
          if (aaa != b)
          {
              if (hash.Contains(aaa))
              {
                  isit = false;
                  break;
              }
              hash.Add(aaa);
              b = aaa;
          }
      }
      if (isit)
          chong++;
  }
  Console.WriteLine(chong);