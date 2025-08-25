int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    string b = Console.ReadLine();
    Stack<char> stack = new Stack<char>();
    bool match = true;
    foreach (char c in b)
    {
        if (c == '(')
        {
            stack.Push(c);
        }
        else if (c == ')')
        {
            if (stack.Count == 0 || stack.Peek() != '(')
            {
                match = false;
                break;
            }
            stack.Pop();
        }
    }
    Console.WriteLine(match && stack.Count == 0 ? "YES" : "NO");
}