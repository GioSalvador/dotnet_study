namespace Aula11;

public class Loops4
{
    public static void Example()
    {
        List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}