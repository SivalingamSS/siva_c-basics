using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa
{
    internal class Class1 : Interface1
    {
        public int Name(int num)
        {
            Console.WriteLine(num);
            return num;
        }
    }
    class program
    {
        public static void main() 
        {
            Class1 b = new Class1();
            b.Name(22);

        }
    }
    
}
