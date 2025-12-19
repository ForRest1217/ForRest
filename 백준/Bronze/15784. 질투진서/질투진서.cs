  int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
  int[][] b = new int[a[0]][];
  for (int i = 0; i < a[0]; i++)
  {
      b[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
  }


  int c = b[a[1] - 1][a[2] - 1];
  bool isit = false;
  for (int j = 0; j < a[0]; j++)
  {
      if (b[a[1] - 1][j] > c)
      {
          isit = true;
          break;
      }
  }
  for (int i = 0; i < a[0] && !isit; i++)
  {
      if (b[i][a[2] - 1] > c)
      {
          isit = true;
          break;
      }
  }

  Console.WriteLine(isit ? "ANGRY" : "HAPPY");