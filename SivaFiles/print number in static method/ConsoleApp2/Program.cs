using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    public class Program
    {
         static void Main(string[] args)
        {
            printnumber(1, 10);
            Console.ReadLine();
        }
        static void printnumber(int sname, int lname)
        {
            if (sname <= lname)
            {
                Console.WriteLine(sname);
                sname++;
               printnumber(sname, lname);

            }
        }

    }
}