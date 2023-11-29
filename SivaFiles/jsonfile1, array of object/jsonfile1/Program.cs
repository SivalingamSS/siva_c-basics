using jsonfile1.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text.Json;

namespace jsonfile1
{
    class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public void str_model()//(1.string convert in model)
        {
            string jsondata = "{\"id\": 22,\"name\":\"siva\" }";

            Department deptList = JsonConvert.DeserializeObject<Department>(jsondata);


            Console.WriteLine("Department id is: {0}", deptList.id);
            Console.WriteLine("Department Fristname is: {0}", deptList.name);

            //json string convert model
             Program program1 = new Program();
             object user = JsonConvert.DeserializeObject("{ \"id\" : \"22\",\"name\" : \"siva\"}");
          
            //Console.WriteLine("1.");
           // Console.WriteLine(deptList + "\n");
        }
        public void model_json()//(2.model convert in json file)
        {
            var obj = new
            {
                Name = "Siva",
                Age = 21,
                Address = "Krishnagiri"
            };
            //ob
            var cal = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Console.WriteLine("2.");
            Console.WriteLine(cal + "\n");
        }
        public void M1()//(4.get one property)
        {
            string path = File.ReadAllText(@"H:\Sivallingam\SivaFiles\jsonfile1 array of object\jsonfile1\jsconfig1.json");
            var input = JsonConvert.DeserializeObject<student>(path);
            Console.WriteLine("4.");
            Console.WriteLine($"FirstName: {input.Firstname}" + "\n");
        }

        public void model_json1()//(5.array of object)
        {
            Console.WriteLine("Json File To Get One object");
            {
                string tet1 = File.ReadAllText(@"H:\Sivallingam\SivaFiles\jsonfile1 array of object\jsonfile1\jsconfigone.json");
                student[] Show = JsonConvert.DeserializeObject<student[]>(tet1);
                string vb = JsonConvert.SerializeObject(Show[0], Formatting.Indented);
                Console.WriteLine("5.");
                Console.WriteLine(vb + "\n");
            }
        }
        public void M2()//(7,8.array of object)
        {
            //(one,multiple object push to new list)
            Department mani = new Department();
            {
                List<student> method = new List<student>();
                method.Add(new student { Firstname = "siva", Lastname = "S", Age = 21 });

                //multiple object push in new list task (7,8)

                method.Add(new student { Firstname = "Thiyaku", Lastname = "N", Age = 22 });
                method.Add(new student { Firstname = "Sridhar", Lastname = "R", Age = 19 });

                
                string Json = JsonConvert.SerializeObject(mani, Formatting.Indented);
                string path = @"H:\Sivallingam\SivaFiles\jsonfile1 array of object\jsonfile1\jsconfig2.json";
                System.IO.File.WriteAllText(path, Json);
                Console.WriteLine("7,8.");
                Console.WriteLine(Json + "\n");

            }

        }
        public void m3()//(6)
        {
            string man = File.ReadAllText(@"H:\Sivallingam\SivaFiles\jsonfile1 array of object\jsonfile1\jsconfigone.json");
            student[] input = JsonConvert.DeserializeObject<student[]>(man);
            Console.WriteLine("6.");
            Console.WriteLine($"Firstname={ input[0].Firstname} ");
        }
        public void m4()//(10)
        {
            //list value convert injson
            var deptList = new List<student>(){
            new student() { Age = 101,Firstname = "IT" },
            new student() { Age = 102,Firstname = "Accounts" }
            };

            string strJson = JsonConvert.SerializeObject(deptList,Formatting.Indented);
            Console.WriteLine("10.");
            Console.WriteLine(strJson);

        }

        static void Main(string[] args)
        {
            Department sa = new Department();
            sa.str_model();
              sa.model_json();
              sa.M1();
              sa.model_json1();
              sa.M2();
              sa.m3();
            sa.m4();

        }

    }
}
/*using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
        CultureInfo jaJP = new CultureInfo("ja-JP");
        jaJP.DateTimeFormat.Calendar = new JapaneseCalendar();
        DateTime date1 = new DateTime(2023, 8, 2);

        try
        {
            Console.WriteLine(date1.ToString(jaJP));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("{0:d} is earlier than {1:d} or later than {2:d}",
                              date1,
                              jaJP.DateTimeFormat.Calendar.MinSupportedDateTime,
                              jaJP.DateTimeFormat.Calendar.MaxSupportedDateTime);
        }
    }
}
// The example displays the following output:
//    1/1/1867 is earlier than 9/8/1868 or later than 12/31/9999   }*/