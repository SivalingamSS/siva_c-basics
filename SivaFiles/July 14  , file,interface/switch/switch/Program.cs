namespace siva;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number");
        int num = Convert.ToInt32(Console.ReadLine());


        switch (num % 5)
        {
            case 1:
                Console.WriteLine("van");
                break;

            case 2:
                Console.WriteLine("tf");
                break;
            default:
                Console.WriteLine("vv");
                break;
        }


        }
    }
