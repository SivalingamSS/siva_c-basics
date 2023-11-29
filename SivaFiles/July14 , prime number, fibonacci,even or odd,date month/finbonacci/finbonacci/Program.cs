namespace finbonacci
{
    public abstract class Program
    {
        public abstract void finbonacci();

        public void name()
        {
            Console.WriteLine("finished");

        }

    }
    public class Program1 : Program

    {
        public override void finbonacci()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("enter the number of elements:");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + "" + n2 + "");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }


        }
        static void Main(string[] args)
        {
            Program1 bro = new Program1();
            bro.finbonacci();
        }
    }

}