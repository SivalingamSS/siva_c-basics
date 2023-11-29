namespace multiple_inheritance
{
    public class mains:Interface1
    {
        public void addition()
        {
            Console.WriteLine("apple");
        }
        public void division()
        {
            Console.WriteLine("mango");
        }
        static void Main(string[] args)
        {
            mains m=new mains();
            m.addition();
            m.division();
        }

    }

}