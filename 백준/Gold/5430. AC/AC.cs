using System.Text;

internal class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < a; i++)
        {
            string b = Console.ReadLine()!;
            int c = int.Parse(Console.ReadLine()!);
            string d = Console.ReadLine()!;

            LinkedList<int> list = new LinkedList<int>();
            string bb = d.Substring(1, d.Length - 2);

            if (bb.Length > 0)
            {
                foreach (string bbb in bb.Split(','))
                    list.AddLast(int.Parse(bbb));
            }

            bool bool1 = false;
            bool bool2 = false;

            foreach (char b2 in b)
            {
                if (b2 == 'R')
                {
                    bool1 = !bool1;
                }
                else if (b2 == 'D')
                {
                    if (list.Count == 0)
                    {
                        bool2 = true;
                        break;
                    }
                    if (bool1)
                        list.RemoveLast();
                    else
                        list.RemoveFirst();
                }
            }

            if (bool2)
            {
                sb.AppendLine("error");
            }
            else
            {
                sb.Append('[');
                if (bool1)
                {
                    var e = list.Last;
                    while (e != null)
                    {
                        sb.Append(e.Value);

                        if (e.Previous != null)
                            sb.Append(',');

                        e = e.Previous;
                    }
                }
                else
                {
                    var e = list.First;
                    while (e != null)
                    {
                        sb.Append(e.Value);

                        if (e.Next != null)
                            sb.Append(',');

                        e = e.Next;
                    }
                }
                sb.AppendLine("]");
            }
        }

        Console.Write(sb.ToString());
    }
}