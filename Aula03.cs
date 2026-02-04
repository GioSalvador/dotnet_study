namespace Aula03;

public class InpuOutput
{
    public static void Exemple()
    {
        Console.WriteLine("-------LOGIN-------");

        Console.WriteLine("Type your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Type your age:");
        int age = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("My name is " + name);
        Console.WriteLine("My age is " + age);
    }
};

