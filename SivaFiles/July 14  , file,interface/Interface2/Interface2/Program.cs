using System;
namespace Interface2
{
     class inter1 : Interface22
    {

        public void odd()
        {

        }
     }
    class inter2 : inter1

    {
        public void even()
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            switch (a % 2)
            {

                case 0:
                    {
                        Console.WriteLine("even");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("odd");
                        break;
                    }
            }
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            inter2 b = new inter2();
            b.even();
        }
    }
}