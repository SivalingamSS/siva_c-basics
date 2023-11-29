namespace bank_program
{
    class Program
    {
        int Amount = 2000;
        public void m1()
        {
            Console.WriteLine("checke the current balance is :" + Amount);
        }
        public void m2()
        {
            int withdraw;
            Console.WriteLine("\nEnter the withdraw Amount : ");
            withdraw = int.Parse(Console.ReadLine());
            if (withdraw % 100 != 0)
            {
                Console.WriteLine("\n Please Enter the Amount Above 100");
            }
            else if (withdraw > (Amount - 500))
            {
                Console.WriteLine("\n Sorry!! Insufficient Balance");
            }
            else
            {
                Amount = Amount - withdraw;
                Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", Amount);
            }
        }
        public void m3()
        {
            int deposit;
            Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
            deposit = int.Parse(Console.ReadLine());
            Amount = Amount + deposit;
            Console.WriteLine("your amount is successfully deposit");

            Console.WriteLine("your total balance is Rs : {0}", Amount);
        }
        public void m4()
        {
            Console.WriteLine("\n THANK YOU…”");

        }

        public void man()
        {
            int pin = 2345;

            Console.WriteLine("Enter the pin");
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());

               while (pin == num)
                {
                    Console.WriteLine("WELCOME TO YES BANK ATM SERVICE\n");
                    Console.WriteLine("1. Current Balance\n");
                    Console.WriteLine("2. Withdraw \n");
                    Console.WriteLine("3. Deposit \n");
                    Console.WriteLine("4. Cancel \n");
                    Console.WriteLine("***************\n\n");
                    Console.WriteLine("ENTER YOUR CHOICE : ");


                    for (int j = 0; true; j++)
                    {
                        int num1 = int.Parse(Console.ReadLine());
                        switch (num1)
                        {
                            case 1:
                                m1();
                                break;
                            case 2:
                                m2();
                                break;
                            case 3:
                                m3();
                                break;

                            case 4:
                                m4();
                                return;

                        }
                    }

                }
                {
                    Console.WriteLine("invalid pin try again");
                }
            }
            
        }         
    }
     
    class program2 :Program
    {
        public static void Main(string[] args)
        {
            program2 p = new program2();
            p.man();
            p.m1();
            p.m2();
            p.m3();
            p.m4();
        }
    }
}