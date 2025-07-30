            int a = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());  
                int c = int.Parse(Console.ReadLine()); 
                int[,] bc = new int[b + 1, c + 1];

                for (int j = 1; j <= c; j++)
                {
                    bc[0, j] = j;
                }

                for (int x = 1; x <= b; x++)
                {
                    for (int y = 1; y <= c; y++)
                    {
                        bc[x, y] = bc[x, y - 1] + bc[x - 1, y];
                    }
                }

                Console.WriteLine(bc[b, c]);
            }