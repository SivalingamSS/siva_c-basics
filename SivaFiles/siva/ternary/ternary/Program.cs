using System;
public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i <=5; i++)
        {

            Console.WriteLine("\nENTER YOUR NUMBER 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number1:  " + num1);
            Console.WriteLine("\nENTER YOUR NUMBER 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number2:  " + num2);
            Console.WriteLine("\nyour operation num:");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 0:
                    Console.WriteLine("your addition is"+(num1 + num2));
                    break;
                case 1:
                    Console.WriteLine("your substraction is" + (num1 - num2));
                    break;
                case 2:
                    Console.WriteLine("your multiplication is" + (num1 * num2));
                    break;
                case 3:
                    Console.WriteLine("your divition is" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("No operation");
                    break;
            }
        }
    }
}
