int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int count = 0;
    int county = 0;
    string b = Console.ReadLine();
    for (int j = 0; j < b.Length; j++)
    {
        if (b[j] == 'O')
        {
            county++;
            count += county;
        }
        else if (b[j] == 'X')
        {
            county = 0;
        }
    }
    Console.WriteLine(count);
}