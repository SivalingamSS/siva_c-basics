namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a;
            Console.WriteLine("enter the multiplication table");
            a = Convert.ToInt32(Console.ReadLine());
            int c;
            for (int i = 1; i <= 10; i++)
            {
                c = a * i;
                Console.WriteLine(i + "*" + a + "=" + c);
            }

        }
    }
}