namespace Aula08;

public class Loops
{
    public static void WhileExemple()
    {
        //Ex 1
        //int i = 0;
        //while (i <=5 )
        //{
        //    Console.WriteLine( i );
        //    i++;
        //}

        //Ex 2
        double budget = 100;
        while (budget > 0)
        {
            Console.WriteLine(budget);
            budget--;
        }
        Console.WriteLine("Insufficient funds");
    }
}