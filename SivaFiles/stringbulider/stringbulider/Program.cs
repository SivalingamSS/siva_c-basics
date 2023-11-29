namespace stringBuilder
{
    internal class Program
    {
        
        static void Main(String[] args)
        {
           SortedDictionary<int, string> a1 = new SortedDictionary<int, string>();
            {
                a1.Add(41, "saran");
                a1.Add(2, "san");
                a1.Add(31, "hello");
                a1.Add(4, "mani");
                a1.Add(11, "siva");
                a1.Remove(31);
                a1.Clear();

                foreach(KeyValuePair<int, string>kvp in a1)
                {
                    Console.WriteLine(kvp);
                }
            }
        }
        enum level
        {
            Sunday,
            monday
        }
    }
}