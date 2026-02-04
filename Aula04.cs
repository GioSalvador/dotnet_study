namespace Aula04;

public class Operators
{
    public static void Calculator()
    {
        Console.WriteLine("-------Simple Calculator-------");
        Console.WriteLine("Type the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Type the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        int sub = number2 - number1;
        int mult = number1 * number2;
        int div = number2 / number1;

        Console.WriteLine("The sum value is: " + sum);
        Console.WriteLine("The substraction value is: " + sub);
        Console.WriteLine("The multiplication value is: " + mult);
        Console.WriteLine("The division value is: " + div);
    }
}