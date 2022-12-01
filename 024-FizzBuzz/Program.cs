Console.Clear();

System.Console.WriteLine("Enter a the biggest number that can be printed ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Enter the divider for Fizz");
int a = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("enter the divider for Buzz");
int b = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    if (i % a == 0 && i % b == 0)
    {
        System.Console.Write("FizzBuzz ");
    }
    else if (i % a == 0)
    {
        System.Console.Write("Fizz ");
    }
    else if (i % b == 0)
    {
        System.Console.Write("Buzz ");
    }
    else
    {
        System.Console.Write($"{i} ");
    }

}
