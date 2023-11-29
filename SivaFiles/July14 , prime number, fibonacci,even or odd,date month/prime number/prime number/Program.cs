namespace primenumber
{
    class primenumber
    {
        public virtual int Primenumber1()
        {
            Console.WriteLine("enter the number:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {

                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            return 0;
     

        }
    }
    class factorial : primenumber
    {
        public override int Primenumber1()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
            return 0;

        }
    }
    class siva
    {

        static void Main(string[] args)
        {

            primenumber obj = new primenumber();
            obj.Primenumber1();
            factorial obj1 = new factorial();
            obj1.Primenumber1();

        }
    }
}
    


   

