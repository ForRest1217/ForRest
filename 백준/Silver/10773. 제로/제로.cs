 int a = int.Parse(Console.ReadLine());
 long c = 0;
 Stack<int> stack = new Stack<int>();

 for (int i = 0; i < a; i++)
 {
     int b = int.Parse(Console.ReadLine());
     if (b == 0)
         stack.Pop(); 
     else
         stack.Push(b); 
 }

while (stack.Count > 0)
{
    c += stack.Pop();
}
 Console.WriteLine(c);