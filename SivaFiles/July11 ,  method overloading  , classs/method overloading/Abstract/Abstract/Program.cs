using System;
namespace Abstract
{
    abstract class horse
    {
        public abstract void college();

        public void student()
        {
            Console.WriteLine("manikandan");
        }

    }
    class siva : horse
    {
        public override void college()
        {
            Console.WriteLine("kapilan");
        }
    }
    class Program
    {
         public static void Main(string[] args)
        {
            siva num = new siva();
            num.student();
            num.college();

        }
    }
}