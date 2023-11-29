
/*  using System;
  namespace Abstract
  {
      sealed class program
      {
       

          public void mee()
          {
              Console.WriteLine("siva");
          }
      }
      sealed class program1
      {
          public  void name()
          {
              Console.WriteLine("man");
          }
          public static void Main(string[] args)
          {
              program1 a = new program1();
              a.name();
            program a1 = new program();
              a1.mee();
          }
      }

  }*/
using System;
namespace Abstract
{
   sealed class program
   {
       public static void mee()
       {
           Console.WriteLine("siva");
       }
   }
   sealed class program1
   {
       public static void name()
       {
           Console.WriteLine("man");
       }
       public static void Main(string[] args)
       {
           program.mee();
           program1.name();

          // program1 a = new program1();

         //  a.name();
         //  program a1 = new program();
        //   a1.mee();
       }
   }
}

/*using System;
namespace partial
{
    partial class program
    {
        public void mee()
        {
            Console.WriteLine("siva");
        }
    }
    partial class program 
    {
        public void name()
        {
            Console.WriteLine("man");
        }
        public static void Main(string[] args)
        {
            program a = new program();
            a.name();
          //  program a1 = new program();
            a.mee();
        }
    }

}*/