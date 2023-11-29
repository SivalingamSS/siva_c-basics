namespace Average
{
    class Program
    {
        public void method1()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            double average = numbers.Average();
            Console.WriteLine(" the avg is {0}", average);
        }
        public void method2()
        {
            List<int> numbers = new List<int> { 30, 40, 50, 60, 70, 80 };
            double sum = numbers.Sum();
            Console.WriteLine("the sum is {0}", sum);
        }
        public void method3()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numbers.Reverse();
            Console.WriteLine(string.Join(',', numbers));
            Console.WriteLine();
        }
        public void method4()
        {
            int a;
            int i = 1;
            int length = 10;
            Console.WriteLine("enter the multiplication table");
            a = Convert.ToInt32(Console.ReadLine());
            int c = 10;
            while (i < length)
            {
                Console.WriteLine($" {i} * {a} = {i * a} ");
                i++;
            }
        }
       /* public void method5()
        {
            DateTime todayDate = DateTime.Now;

            Console.WriteLine("Current Date : {0}", todayDate.ToFullDateTimeString());

            DateTime tomorrow = todayDate.Yesterday();

            Console.WriteLine("After calling Yesterday: {0}", tomorrow.ToFullDateTimeString());
        }
        */
        static void Main(string[] args)
        {
                Program sa = new Program();
                sa.method1();
                sa.method2();
                sa.method3();
                sa.method4();
             //   sa.method5();
              //  sa.method6();
           


        }
    }
}