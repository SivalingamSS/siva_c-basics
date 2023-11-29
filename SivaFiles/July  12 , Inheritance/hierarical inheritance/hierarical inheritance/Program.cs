namespace hierarical_inheritance
{
    class A
    {
        public void name()
        {
            Console.WriteLine("mani");
        }
    }
    class B : A
    {
        public void saran()
        {
            Console.WriteLine("kapilan");
        }
    }
    class c : A
    {
        public void math()
        {
            Console.WriteLine("man");
        }
        public void div()
        {
            Console.WriteLine("man");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            B ble = new B();
            ble.saran();
            ble.name();

            c see=new c();
            see.math();
            see.name();
            see.div();
        }

    }
}