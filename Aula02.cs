namespace Aula02;

public class Variables
{
    public void ShowVariable()
    {
        string myName = "Giovani";                  // String SEMPRE com áspas duplas
        int number = 777;                          // Números inteiros
        double numberDouble = 29.08;              //Números com vírgula
        char character = 'a';                    //Apenas um caractére, e SEMPRE com áspas simples
        bool boolean = false;                   //Booleano TRUE ou FALSE

        Console.WriteLine(myName);  
        Console.WriteLine(number);  
        Console.WriteLine(numberDouble);  
        Console.WriteLine(character);  
        Console.WriteLine(boolean);  
    }
}