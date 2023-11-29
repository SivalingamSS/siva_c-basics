using System.Reflection.Metadata;


namespace Duplicates_array
{
    internal class Program
    {
        public void name()
        {
            int[] a = { 55,67,88,99,78,45,23,33,55,99 };
            int[] c = a.Distinct().ToArray();//removes the duplicate elements from a sequence (list) and returns the distinct elements from a single data source.
            foreach (int i in c)

            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------");

           

        }
        public void split()
        {
            string split =  "sivalingam";
            char[] s = split.ToCharArray();
            foreach(char i in s)  
            {
                Console.WriteLine(i);
            }
            {
                Console.WriteLine("---------------------------------------");
            }
        }
        public  void reverse()
        {
            string name = "welcome to programming langauage";
            char[] s = name.ToCharArray();
            Array.Reverse(s);
            Console.WriteLine(s);
            
                Console.WriteLine("---------------------------------------");
            

        }
       public void Dup()
        {
            string name = "welcome to programming langauage";
            HashSet<char> d = new HashSet<char>(name);//HashSet<E> hs = new HashSet<E>(Collection C)
            foreach (char i in d)
                Console.Write(i);
            {
                Console.WriteLine("---------------------------------------------");
            }
        }
       
        static void Main(string[] args)
        {
            Program See = new Program();
            See.name();
            See.split();
            See.reverse();
            See.Dup();

        }
    }
}