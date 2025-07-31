            string[] a = new string[3];
            int b = -1;
            int c = -1;

            for (int i = 0; i < 3; i++)
            {
                a[i] = Console.ReadLine();

                bool istrue = true;
                foreach (char d in a[i])
                {
                    if (d < '0' || d > '9')
                    {
                        istrue = false;
                        break;
                    }
                }
                if (istrue)
                {
                    b = int.Parse(a[i]);
                    c = b - i;
                }
            }

            int next = c + 3;
            if (next % 3 == 0 && next % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (next % 3 == 0)
                Console.WriteLine("Fizz");
            else if (next % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(next);