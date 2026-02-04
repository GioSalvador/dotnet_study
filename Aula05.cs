namespace Aula05;

public class Conditional
{
    public static void Structure()
    {
        Console.WriteLine("-------Number verifier-------");
        Console.WriteLine("Type your number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;

        if (result == 0)
        {
            Console.WriteLine("The number " + number + " is even");
        }else
        {
            Console.WriteLine("The number " + number + " is odd");
        }
    }
}