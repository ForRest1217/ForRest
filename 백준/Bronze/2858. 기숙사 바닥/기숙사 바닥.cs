  int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
  int b = a[0] + a[1];
  for (int i = 1; i <= Math.Sqrt(a[1]); i++)
  {
      if (a[1] % i == 0)
      {
          int c = a[1] / i + 2;
          int cc = i + 2;

          if (c * cc == b)
          {
              Console.WriteLine($"{c} {cc}");
              return;
          }
      }
  }