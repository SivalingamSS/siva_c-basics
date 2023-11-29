using System;
namespace interfacee
{

        interface  program
        { 
            public void man1();
        }
        public class pro : program
        {
            public void man1()
            {
                Console.WriteLine("odd");
            }
        }
  
       public interface mani
       {
        public void mani1();
       }
       public class save : mani
       {
           public void mani1()
          {
            Console.WriteLine("even");
           }
       }
    class program4
    {
        public  static void Main(string[] args)
        {
            pro a = new pro();
            a.man1();
           save b = new save(); 
            b.mani1();
        }
    }

}








