using System.Data;
using System.Runtime.CompilerServices;
namespace string_function
{
    internal class Program
    {
        public void compareto()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void compare()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void compareordinal()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(string.CompareOrdinal(s1, s2));
            Console.WriteLine(string.CompareOrdinal(s1, s3));
            Console.WriteLine(string.CompareOrdinal(s1, s4));
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void concat()
        {
            string s1 = "Hello ";
            string s2 = "C#";
            Console.WriteLine(string.Concat(s1, s2));
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void contains()
        {
            string s1 = "Hello ";
            string s2 = "He";
            string s3 = "Hi";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void copy()
        {
            string s1 = "Hello ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void copyTo()
        {
            string s1 = "Hello C#, How Are You?";
            char[] ch = new char[15];
            s1.CopyTo(10, ch, 0, 12);
            Console.WriteLine(ch);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void endswith()
        {
            string s1 = "Hello";
            string s2 = "llo";
            string s3 = "C#";
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void equals()
        {
            string s1 = "Hello";
            string s2 = "Hello";
            string s3 = "Bye";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void format()
        {
            string s1 = string.Format("{0:D}", DateTime.Now);
            Console.WriteLine(s1);

            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void remove()
        {
            string s1 = "Hello C#";
            string s2 = s1.Remove(2);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void replace()
        {
            string s1 = "Hello F#";
            string s2 = s1.Replace('F', 'C');
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void split()
        {
            string s1 = "Hello C Sharp";
            string[] s2 = s1.Split(' ');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void startwith()
        {
            string s1 = "Hello C Sharp";
            bool b1 = s1.StartsWith("h");
            bool b2 = s1.StartsWith("H");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void substring()
        {
            string s1 = "Hello C Sharp";
            string s2 = s1.Substring(5);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void tolower()
        {
            string s1 = "Hello C#";
            string s2 = s1.ToLower();
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void tolowerInvar()
        {
            string s1 = "Hello C#";
            string s2 = s1.ToLowerInvariant();
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void tostring()
        {
            string s1 = "Hello C#";
            int a = 123;
            string s2 = s1.ToString();
            string s3 = a.ToString();
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void toupper()
        {
            string s1 = "Hello C#";
            string s3 = s1.ToUpper();
            Console.WriteLine(s3);
            {
                Console.WriteLine("--------------------------------------");
            }


        }
        public void toupperInvar()
        {
            string s1 = "Hello C#";
            string s3 = s1.ToUpperInvariant();
            Console.WriteLine(s3);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void trim()
        {
            string s1 = "Hello C#";
            string s2 = s1.Trim();
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void trimend()
        {
            string s1 = "Hello C#";
            char[] ch = { '#' };
            string s2 = s1.TrimEnd(ch);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void trimstarts()
        {
            string s1 = "Hello C#";
            char[] ch = { 'H' };
            string s2 = s1.TrimStart(ch);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void join()
        {
            string[] s1 = { "Hello", "C#", "by", "javatpoint" };
            string s3 = string.Join("-", s1);
            Console.WriteLine(s3);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void laastindexofany()
        {
            string s1 = "abracadabra";
            char[] ch = { 'r', 'b' };
            int index = s1.LastIndexOfAny(ch);//Finds 'r' at the last  
            Console.WriteLine(index);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void laastindexof()
        {
            string s1 = "Hello C#";
            int index = s1.LastIndexOf('l');
            Console.WriteLine(index);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void clone()
        {
            string s1 = "Hello ";
            string s2 = (String)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void padRigth()
        {
            string s1 = "Hello C#";
            string s2 = s1.PadRight(15);
            Console.Write(s2);
            Console.Write("JavaTpoint");
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void padleft()
        {
            string s1 = "Hello C#";
            string s2 = s1.PadLeft(10);
            Console.WriteLine(s2);

            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void nullorwhitespaces()
        {
            string s1 = "Hello C#";
            string s2 = "";
            string s3 = " ";
            bool b1 = string.IsNullOrWhiteSpace(s1);
            bool b2 = string.IsNullOrWhiteSpace(s2);
            bool b3 = string.IsNullOrWhiteSpace(s3);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void nullorempty()
        {
            string s1 = "Hello C#";
            string s2 = "";
            bool b1 = string.IsNullOrEmpty(s1);
            bool b2 = string.IsNullOrEmpty(s2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void normalize()
        {
            string s1 = "Hello C#";
            string s2 = s1.Normalize();
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }

        }
        public void normalized()
        {
            string s1 = "Hello C#";
            bool b1 = s1.IsNormalized();
            Console.WriteLine(s1);
            Console.WriteLine(b1);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void Isinterend()
        {
            string s1 = "Hello C#";
            string s2 = string.Intern(s1);
            string s3 = string.IsInterned(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void intere()
        {
            string s1 = "Hello C#";
            string s2 = string.Intern(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void insert()
        {
            string s1 = "Hello C#";
            string s2 = s1.Insert(5, "-");
            Console.WriteLine(s2);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void indexof()
        {
            string s1 = "Hello C#";
            int index = s1.IndexOf('e');
            Console.WriteLine(index);
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void gettypeecode()

        {
            string s1 = "Hello C#";
            Console.WriteLine(s1.GetTypeCode());
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void gettypee()
        {
            string s1 = "Hello C#";
            Console.WriteLine(s1.GetType());
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void gethashcodee()
        {
            string s1 = "Hello C#";
            Console.WriteLine(s1.GetHashCode());
            {
                Console.WriteLine("--------------------------------------");
            }
        }
        public void geteneumerator()
        {
            string s2 = "Hello C#";
            CharEnumerator ch = s2.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
                {
                    Console.WriteLine("--------------------------------------");
                }
            }
        }
        public void strings ()
        
       { 
            string s1 = "hello";

           char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2 = new string(ch);
            Console.WriteLine(s1);  
             Console.WriteLine(s2);
             {
                    Console.WriteLine("--------------------------------------");
             }
            
        }
          static void Main(string[] args)
          {
            Program bro = new Program();
            bro.compareto();
            bro.compare();
            bro.compareordinal();
            bro.concat();
            bro.contains();
            bro.copy();
            bro.copyTo();
            bro.endswith();
            bro.equals();
            bro.format();
            bro.remove();
            bro.replace();
            bro.split();
            bro.startwith();
            bro.substring();
            bro.tolower();
            bro.toupperInvar();
            bro.ToString();
            bro.toupper();
            bro.tolowerInvar();
            bro.trim();
            bro.trimstarts();
            bro.trimend();
            bro.join();
            bro.laastindexof();
            bro.laastindexofany();
            bro.intere();
            bro.Isinterend();
            bro.normalize();
            bro.normalized();
            bro.nullorempty();
            bro.nullorwhitespaces();
            bro.padleft();
            bro.padRigth();
            bro.clone();
            bro.insert();
            bro.gethashcodee();
            bro.insert();
            bro.gettypeecode();
            bro.gettypee();
            bro.indexof();
            bro.strings();
            bro.geteneumerator();
          }
    }
}