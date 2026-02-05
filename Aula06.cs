namespace Aula06;

public class Operators2
{
    public static void Calculator2()
    {
        Console.WriteLine("-------Simple Calculator 2.0-------\n");
        Console.WriteLine("Type the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Type the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose the operation: ");
        Console.WriteLine("1. Sum (+)");
        Console.WriteLine("2. Sub (-)");
        Console.WriteLine("3. Multiply (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("Type operation number: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        if (operation == 1)
        {
            result = num1 + num2;
        }
        else if (operation == 2)
        {
            result = num1 - num2;
        }
        else if (operation == 3)
        {
            result = num1 * num2;
        }
        else if (operation == 4)
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("N/A");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation");
        }
        Console.WriteLine("\nResult: " + result);
    }
}