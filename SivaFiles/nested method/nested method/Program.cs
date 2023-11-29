/*namespace nested_method
{
    internal class Program
    {
        public void m1()
        {
               int z = myNestedMethod(5, 4); // Accessing Nested Method

                Console.WriteLine(z);

                int myNestedMethod(int x, int y)
                {
                    int result = x + y; // accessing variable a

                    int square = myNewNestedMethod(result, 2);

                    int myNewNestedMethod(int num1, int num2)
                    {
                        int result2 = Convert.ToInt32(Math.Pow(num1, num2));
                        return result2;
                    }

                    return square;
                }

                Console.ReadKey();
           
        }
        class   program
        {
            public static void Main()
            {
               Program q = new Program();
                q.m1();
            }
        }
    }

}*/

using System;
namespace try_catch
{
    class program
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] mynumber = { 1 ,2 ,1 , 2};
                Console.WriteLine(mynumber[0]);
            }
            catch 
            {
                Console.WriteLine("SDFGHJK");
            }
            finally
            {
                Console.WriteLine("try is finished");
            }

        }
    }
}
