System.Console.WriteLine("please enter a positiv number: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("please enter another positiv number: ");
int m = int.Parse(Console.ReadLine()!);

int i = 1, j = 1;


while (n > 1)
{
    if (n % 2 == 0)
    {
        n /= 2;
    }
    else
    {
        n = (3 * n) + 1;
    }
    i++;
}
while (m > 1)
{
    if (m % 2 == 0)
    {
        m /= 2;
    }
    else
    {
        m = (3 * n) + 1;
    }
    j++;
}
if (i > j)
{
    System.Console.WriteLine($"The first sequence is longer({i})");
}
else
{
    System.Console.WriteLine($"The second sequence is longer({j})");
}

