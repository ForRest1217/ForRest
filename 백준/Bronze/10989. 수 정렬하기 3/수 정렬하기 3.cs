int a = int.Parse(Console.ReadLine());
int[] b = new int[10001];
for (int i = 0; i < a; i++)
{
    int aa = int.Parse(Console.ReadLine());
    b[aa]++;
}

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
for (int i = 1; i <= 10000; i++)
{
    for (int j = 0; j < b[i]; j++)
    {
        sw.WriteLine(i);
    }
}
sw.Flush();
sw.Close();