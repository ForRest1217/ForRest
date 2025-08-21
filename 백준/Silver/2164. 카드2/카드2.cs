int a = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
for (int i = 1; i <= a; i++)
{
    queue.Enqueue(i);
}
while (queue.Count > 1)
{
    queue.Dequeue();
    queue.Enqueue(queue.Dequeue());
}
Console.WriteLine(queue.Peek());