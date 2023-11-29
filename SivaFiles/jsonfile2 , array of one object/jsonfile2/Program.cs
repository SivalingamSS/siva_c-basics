using jsonfile2.modal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace jsonfile2
{
    class Program
    {
        public void siva()
        {
            string man = File.ReadAllText(@"H:\Sivallingam\SivaFiles\jsonfile2\jsonfile2\jsconfig1.json");
            student[] Show = JsonConvert.DeserializeObject<student[]>(man);
            // string vb = JsonConvert.SerializeObject(Show[0], Formatting.Indented);
            foreach (student student in Show)
            {
                var bad = new student1()
                {
                    FristName = student.FristName,
                    LastName = student.LastName,
                    id = student.id

                };
                if (bad.id >= 23)
                {
                    Console.WriteLine(student.FristName);
                    Console.WriteLine(student.LastName);
                    Console.WriteLine(student.id);
                }
            }
        }
        public void siva2()
        {
            string tet1 = File.ReadAllText(@"H:\Sivallingam\SivaFiles\jsonfile2\jsonfile2\jsconfig1.json");
            student[] Show = JsonConvert.DeserializeObject<student[]>(tet1);
             // string vb = JsonConvert.SerializeObject(Show, Formatting.Indented);
            //var student = new student();
            if (Show[0] == null)
            {
                Console.WriteLine();
            }
            //Console.WriteLine("5.");
           // Console.WriteLine(vb + "\n");
        }
        public static void Main(string[] args)
        {
            Program num = new Program();
            num.siva();
            num.siva2();
        }
    }
}