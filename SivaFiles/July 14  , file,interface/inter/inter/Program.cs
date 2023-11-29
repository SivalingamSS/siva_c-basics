namespace inter
{
    internal class Program : Interface1
    {

        public void name()
        {
            Console.WriteLine("siva");
        }

        class program1 : Interface3
        {
            public void size()
            {
                Console.WriteLine("mani");
            }
        }
    }
    class program2
    {
        public static void Main(string[] args)
        {
            Program b= new Program();
            b.name();   
        }
    }
    
}        