int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool ascending = false;
bool descending = false;

for (int i = 0; i < a.Length - 1; i++)
{
    if (a[i] < a[i + 1])
        ascending = true;
    else if (a[i] > a[i + 1])
        descending = true;
}

if (ascending && !descending)
    Console.WriteLine("ascending");
else if (!ascending && descending)
    Console.WriteLine("descending");
else
    Console.WriteLine("mixed");