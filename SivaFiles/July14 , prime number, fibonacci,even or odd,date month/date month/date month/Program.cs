namespace date_month
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first date (yyyy-mm-dd):");

            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second date (yyyy-mm-dd):");

            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan du = secondDate - firstDate;

            int numberOfDays = du.Days;

            int month = (firstDate - secondDate).Days / 30;
            Console.WriteLine(" number of month between the :" + month);


            Console.WriteLine("Number of days between the two dates: " + numberOfDays);
        }
    }
}