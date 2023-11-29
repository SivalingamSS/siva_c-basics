namespace jsonfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\sivalingam\jsonfile\jsonfile\jsconfig1.json";
            string readText = File.ReadAllText(path); 
            Console.WriteLine(readText);
        }
    }
}