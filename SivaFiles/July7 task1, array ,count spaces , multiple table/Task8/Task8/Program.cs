namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String string1 = "The best of botha worlds";
            int count =0;
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] == 'a')
                    count++;
            }
            Console.WriteLine("Total number of characters in a string: " + count);
        }
    
    }
}