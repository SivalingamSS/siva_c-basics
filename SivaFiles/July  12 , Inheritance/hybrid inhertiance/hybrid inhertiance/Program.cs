namespace hybrid_inhertiance
{

    class A
    {
        public void name()
        {
            Console.WriteLine("siva");
        }

    }
    class B : A
    {
        public void date()
        {
            Console.WriteLine("kapilan");

        }
    }
    class C : B
    {
        public void size()
        {
            Console.WriteLine("siva");
        }
    }
    class D : B
    {
        public void Time()
        {
            Console.WriteLine("comdey");

        }
    }
    public class hybridinheritance
    {
        static void Main(string[] args)
        {
            C mani = new C();
            mani.name();
            mani.date();
            mani.size();
            D m = new D();
            m.name();
            m.date();
            m.Time();

        }
    }
}