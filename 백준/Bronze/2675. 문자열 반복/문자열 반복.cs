int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    string[] b = Console.ReadLine().Split();
    int c = int.Parse(b[0]);
    string d = b[1];
    string st = "";
    foreach (char e in d)
    {
        for (int k = 0; k < c; k++)
            st += e;
    }
    Console.WriteLine(st);
}