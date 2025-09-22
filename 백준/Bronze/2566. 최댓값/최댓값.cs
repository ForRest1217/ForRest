    int[,] a = new int[9, 9];
    int b = int.MinValue;
    int[] c = new int[2];
    for (int i = 0; i < 9; i++)
    {
        int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int j = 0; j < 9; j++)
        {
            if (b < aa[j])
            {
                b = aa[j];
                c[0] = i + 1;
                c[1] = j + 1;
            }
            a[i, j] = aa[j];
        }
    }

    Console.WriteLine(b);
    Console.WriteLine(c[0] + " " + c[1]);