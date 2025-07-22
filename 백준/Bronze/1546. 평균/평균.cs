int a = int.Parse(Console.ReadLine());
string[] d = Console.ReadLine().Split(' ');
float[] b = new float[a];
float c = 0;
for (int i = 0; i < a; i++)
{
    b[i] = float.Parse(d[i]);
    if (b[i] > c)
        c = b[i];
}
float e = 0;
for (int i = 0; i < a; i++)
{
    e += (b[i] / c) * 100f;
}
Console.WriteLine(e / a);