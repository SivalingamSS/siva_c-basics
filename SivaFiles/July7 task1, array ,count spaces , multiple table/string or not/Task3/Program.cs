namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                char s = 'w';

                if (s.GetType() == typeof(char))
                {
                    Console.WriteLine(" IT is char");
                }
                else
                {
                    Console.WriteLine("it is number");
                }
        }
    }
}