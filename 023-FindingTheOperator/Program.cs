System.Console.WriteLine("Please enter the first number of your oparation (<0)");
int number1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Please enter the second number of your oparaton(<0)");
int number2 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Please enter the result of the operation");
double result = int.Parse(Console.ReadLine()!);

if ((number1 + number2) == result)
{
    System.Console.WriteLine("The oparater was PLUS");
}
else if (number1 - number2 == result || number2 - number1 == result)
{
    System.Console.WriteLine("the oparater was MINUS");
}
else if (number1 * number2 == result)
{
    System.Console.WriteLine("the oparator was MULTYPLY");
}
else if (Math.Round((double)number1 / number2, 2) == result || Math.Round((double)number2 / number1, 2) == result)
{
    System.Console.WriteLine("the operater was DIVIDE");
}
else if (Math.Pow(number1, number2) == result || Math.Pow(number2, number1) == result)
{
    System.Console.WriteLine("the operator was EXPONENTIATON ");
}
else if (number1 % number2 == result || number2 % number1 == result)
{
    System.Console.WriteLine("The oparator was MODULO");
}
