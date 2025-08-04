int a = int.Parse(Console.ReadLine()); 
int[] b = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int c = 0;
int d = 0;
Array.Sort(b);

for (int i = 0; i < a; i++)
{
    c += b[i]; 
    d += c;     
}
Console.WriteLine(d);