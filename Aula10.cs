using Aula05;

namespace Aula10;

public class Loops3
{
    public static void ForExemple()
    {
        //for (condition 1; condition 2; condition 3)
        //{
        //    Executed code
        //}

        //Condition 1 is executed (one time) before the code block excecution.
        //Condition 2 defines a condition to execute the code block.
        //Condition 3 is executed (every time) after the code block is executed.

        //Ex 1
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        Console.WriteLine("-------Multiplication Table-------");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j, 6}");
            }
            Console.WriteLine();
        }
    }
}