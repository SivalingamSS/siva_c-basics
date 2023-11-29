using json11task.model;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.Security.Cryptography.X509Certificates;

namespace json11task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet("GetDepartment string convert to model")]
        // object = base type of all other types
        public object GetDepartment()
        {
            string jsondata = "{\"id\": 22,\"name\":\"siva\" }";

            Department deptList = JsonConvert.DeserializeObject<Department>(jsondata);


           // Console.WriteLine("Department id is: {0}", deptList.Id);
            //Console.WriteLine("Department Fristname is: {0}", deptList.Name);
            // Department rep = await _GetDepartment.Department();
            return (deptList);
        }

        [HttpGet("GetDepartment2 model convert to json file")]
        public object GetDepartment2()
        {
            var obj = new
            {
                id = 22,
                name = "siva",
                address = "xyza",
                amount = 2000,
                collegename = "srnvcas"
            };
            var rep1 = JsonConvert.SerializeObject(obj, Formatting.Indented);

            string str = (@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig1.json");
            System.IO.File.WriteAllText(str, rep1);
            return rep1;
        }

        [HttpGet("Getname3 read json file assign the model")]
        public object Getname3()
        {
            string man = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] input = JsonConvert.DeserializeObject<Department[]>(man);
            var result = JsonConvert.SerializeObject(input[2], Formatting.Indented);
            return result;
        }
        [HttpGet("Getname4 get one property")]
        public object get4()
        {
            string path = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] input = JsonConvert.DeserializeObject<Department[]>(path);
            var middle = $"FirstName: {input[2].Name}";
            return middle;
        }
        [HttpGet(" json array of object any one object to show")]
        public object get5()
        {
            string tet1 = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] Show = JsonConvert.DeserializeObject<Department[]>(tet1);
            foreach (Department str in Show)
            {
                string vb = JsonConvert.SerializeObject(str, Formatting.Indented);
                return vb;
            }

            return 0;
        }
        [HttpGet("json array of object any one object in that one property")]
        public object get6()
        {
            string team = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] Show = JsonConvert.DeserializeObject<Department[]>(team);
            //  string input = JsonConvert.SerializeObject(Show[0], Formatting.Indented);
            foreach (Department str in Show)
            {
                var vb = $"FirstName: {str.Name}";
                return vb;

            }
            return 0;

        }
        [HttpGet("json array of object any one object  push to new list")]
        public object get7()
        {
            string test4 = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] noo = JsonConvert.DeserializeObject<Department[]>(test4);
            List<Department> jsonss = new List<Department>();

            for (int i = 0; i < noo.Length; i++)

            {
                if (noo[i].Id == 23)
                {
                    jsonss.Add(noo[i]);
                }
            }
            return jsonss;
        }
        [HttpGet("json array of object any multiple object  push to new list")]
        public object get8()
        {
            string test4 = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] noo = JsonConvert.DeserializeObject<Department[]>(test4);
            List<Department> jsonss = new List<Department>();

            for (int i = 0; i < noo.Length; i++)

            {
                if (noo[i].Id >= 22)
                {
                    jsonss.Add(noo[i]);
                }
            }
            return jsonss;
        }
        [HttpGet("json")]
        public object get9()
        {
            string tet1 = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] okey = JsonConvert.DeserializeObject<Department[]>(tet1);

            foreach (Department van in okey)
            {
                Employee Format = new Employee()
                {
                    EmployeeId = van.Id,
                    EmployeeName = van.Name,
                    EmployeeAddress = van.Address,
                    EmployeeAmount = van.Amount,
                    EmployeecollegeName = van.collegeName
                };
                return Format;
            }
            return 0;

        }
        [HttpGet("json array of object any list convert to json")]

        public object get10()
        {
            var deptList = new List<Department>(){
            new Department() { Id = 101,Name = "IT" },
            new Department() { Id = 102,Name = "Accounts" }
            };
            foreach (Department van in deptList)
            {
                string strJson = JsonConvert.SerializeObject(van, Formatting.Indented);
                return strJson;
            }
            return 0;
        }
        [HttpGet("UniqueId and Duplicates in list")]
        public object get11()
        {
            string str = System.IO.File.ReadAllText(@"H:\Sivallingam\SivaFiles\json11task\json11task\jsconfig.json");
            Department[] type = JsonConvert.DeserializeObject<Department[]>(str);
            List<Department> sun = new List<Department>();
            List<Department> son = new List<Department>();
            foreach (var list_ans in type)
            {
                if (list_ans.Id == 22)
                {
                    sun.Add(list_ans);

                }
                else
                {
                    son.Add(list_ans);
                }
            }
            return new { sun,son };
       
        }
    }
}


