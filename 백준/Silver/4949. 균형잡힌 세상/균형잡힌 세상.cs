while (true)
{
    string a = Console.ReadLine();
    if (a == ".")
        break;

    Stack<char> stack = new Stack<char>();
    bool match = true;
    foreach (char b in a)
    {
        if (b == '(' || b == '[')
        {
            stack.Push(b);
        }
        else if (b == ')')
        {
            if (stack.Count == 0 || stack.Peek() != '(')
            {
                match = false;
                break;
            }
            stack.Pop();
        }
        else if (b == ']')
        {
            if (stack.Count == 0 || stack.Peek() != '[')
            {
                match = false;
                break;
            }
            stack.Pop();
        }
    }
    if (match && stack.Count == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}