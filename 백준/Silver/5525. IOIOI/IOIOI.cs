int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string c = Console.ReadLine();

int d = 0;
int e = 0;

for (int i = 1; i < b - 1; i++)
{
    if (c[i - 1] == 'I' && c[i] == 'O' && c[i + 1] == 'I')
    {
        d++;

        if (d == a)
        {
            e++;
            d--;
        }
        i++;
    }
    else
    {
        d = 0;
    }
}

Console.WriteLine(e);