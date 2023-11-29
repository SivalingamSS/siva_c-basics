using System.Transactions;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 12;
                int b = 13;
                
                {
                    Console.WriteLine(a < b && a > b);
                    Console.WriteLine(a < b || a > b);
                    Console.WriteLine(!(a < b && a > b));

                }
            }

        }  
    }
}