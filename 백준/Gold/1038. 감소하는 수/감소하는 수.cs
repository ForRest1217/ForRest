int a = int.Parse(Console.ReadLine());

if (a >= 1023)
{
    Console.WriteLine(-1);
    return;
}

if (a <= 9)
{
    Console.WriteLine(a);
    return;
}

Queue<long> queue = new Queue<long>();

for (int i = 0; i <= 9; i++)
    queue.Enqueue(i);

int b = -1;
long c = 0;

while (queue.Count > 0)
{
    long aa = queue.Dequeue();
    b++;

    if (b == a)
    {
        c = aa;
        break;
    }

    for (int i = 0; i < aa % 10; i++)
    {
        queue.Enqueue(aa * 10 + i);
    }
}

Console.WriteLine(c);