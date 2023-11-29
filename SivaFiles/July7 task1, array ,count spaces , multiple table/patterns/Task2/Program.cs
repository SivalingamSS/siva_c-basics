namespace Task2
{
    internal class patterns
    {


        public void method1()
        {
            for (int i = 0; i <= 5; i++)

            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                {

                    Console.Write("\n");
                }
            }
        }
        public void method2()
        {
            for (int i = 0; i <= 5; i++)
            {

                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                {

                    Console.Write("\n");
                }
            }
        }
        public static void Main(String[] args)
        {
            patterns str = new patterns();
            str.method1();
            str.method2();

        }

    }
}

        
    
