namespace hhh
{
    interface Iinter
    {
        public void man1();
        public void man10();
        public void man15();
        public void man17();
        public void man11();
    }
    class program : Iinter
    {
        public void man1()
        {
            Console.WriteLine("VBNM");
        }
        public void man11()
        {
            Console.WriteLine("VBNM");
        }
        public void man10()
        {
            Console.WriteLine("VBNM");
        }
        public void man17()
        {
            Console.WriteLine("VBNM");
        }
        public void man15()
        {
            Console.WriteLine("VBNM");
        }


    }
    class Program
    {
        public static void Main(string[] args)
        {
            program n = new program();
            n.man1();
            n.man11();
            n.man17();
            n.man15();
            n.man10();

        }
    }
}
    


