using Aula01;
using Aula02;
using Aula03;
using Aula04;
using Aula05;

public class Program
{
    public static void Main()
    {
        //Aula 01
        Console.WriteLine("--------------");
        Console.WriteLine("Aula 01");
        Console.WriteLine("--------------");

        PrintConsole.SayHelloWorld();

        //Aula 02
        Console.WriteLine("--------------");
        Console.WriteLine("Aula 02");
        Console.WriteLine("--------------");

        Variables variables = new Variables();
        variables.ShowVariable();

        //Aula 03
        Console.WriteLine("--------------");
        Console.WriteLine("Aula 03");
        Console.WriteLine("--------------");

        //InpuOutput.Exemple();

        //Aula 04
        Console.WriteLine("--------------");
        Console.WriteLine("Aula 04");
        Console.WriteLine("--------------");

        //Operators.Calculator();

        //Aula 05
        Console.WriteLine("--------------");
        Console.WriteLine("Aula 05");
        Console.WriteLine("--------------");

        Conditional.Structure();
    }
}