using System;
namespace consoleapp1
{
    public class program1
    {
        protected void name3()
        {
            Console.WriteLine("SIVA");
        }
        protected void age3()
        {
            Console.WriteLine("12");
        }

      
        public class program2 :program1
        {
            public void name1()
            {
                Console.WriteLine("mani");
            }
            public void age1()
            {
                Console.WriteLine("12");
            }
        }

        public class program3 :program2
        {
            protected void name()
            {
                Console.WriteLine("SIVA");
            }
            protected void age()
            {
                Console.WriteLine("12");
            }

            protected void size()
            {
                Console.WriteLine("23");
            }
            protected void age2()
            {
                Console.WriteLine("22");
            }
            //     class program2 
            //  {

            public static void Main(string[] args)
            {
                program3 d = new program3();
                d.name();
                d.age();
                d.age2();
                d.size();
                d.age1();
                d.name1();
                d.age3();
                d.name3();

            }
        }

            
        
    }
}
