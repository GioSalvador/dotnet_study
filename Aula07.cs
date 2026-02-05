namespace Aula07;

public class SwitchCase
{
    public static void Exemple()
    {
        Console.WriteLine("---------Day of week---------\n");
        Console.WriteLine("Type a number from 1 to 7:");
        int dayOfWeek = (int)Convert.ToUInt32(Console.ReadLine());

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("It's Sunday");
                break;

            case 2:
                Console.WriteLine("It's Monday");
                break;

            case 3:
                Console.WriteLine("It's Tuesday");
                break;

            case 4:
                Console.WriteLine("It's Wednesday");
                break;

            case 5:
                Console.WriteLine("It's Thursday");
                break;

            case 6:
                Console.WriteLine("It's Friday");
                break;

            case 7:
                Console.WriteLine("It's Saturday");
                break;

            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}