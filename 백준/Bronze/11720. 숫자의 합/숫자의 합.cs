int n = int.Parse(Console.ReadLine()); 
string numbers = Console.ReadLine(); 

int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += numbers[i] - '0';  
}

Console.WriteLine(sum);  