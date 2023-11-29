namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "hello wow if g";
            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]  == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}