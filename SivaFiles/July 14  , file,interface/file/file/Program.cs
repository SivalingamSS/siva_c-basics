namespace file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("F:\\siva kapilan.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}