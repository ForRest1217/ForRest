string[] a = Console.ReadLine().Split();
int aa = int.Parse(a[0]);
char aaa = a[1][0];
HashSet<string> hashSet = new HashSet<string>();
for (int i = 0; i < aa; i++)
{
    hashSet.Add(Console.ReadLine());
}

int b = 0;
if (aaa == 'Y') 
    b = 1;
else if (aaa == 'F') 
    b = 2;
else if (aaa == 'O') 
    b = 3;

Console.WriteLine(hashSet.Count / b);