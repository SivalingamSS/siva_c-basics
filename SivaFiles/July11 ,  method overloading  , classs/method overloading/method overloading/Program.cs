using System.Data;

namespace method_overloading
{
    internal class Program
    {
        public int arthmetic( int a)
        {
            int sum = a + 7;
            Console.WriteLine("addtion :"+ sum);
            return 0;
        }
        public int arthmetic(int a,int b)
        {
            int sum = a + 7;
            Console.WriteLine("addtion :" + sum);
            return 0;
        }
        public int arthmetic(int a, int b,int c) 
        {
            int sub = c - b;
            Console.WriteLine("sub :"+ sub );
            return 0;
        }
        public int arthmetic(int a, int b,int c,int d) 
        {
            int multi = a *b  * c*d;
            Console.WriteLine("multi:"+ multi);
            return 0;
        }
        public int arthmetic(int a, int b,int c, int e,int s)
        {
            int div = a/ b /c/e/s;
            Console.WriteLine("div:" + div);
            return 0;
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            s.arthmetic(6);
            s.arthmetic(9);
            s.arthmetic(7, 12,22);
            s.arthmetic(8, 13,1,3);
            s.arthmetic(3, 5, 15, 55 ,6);
        }
    }
}