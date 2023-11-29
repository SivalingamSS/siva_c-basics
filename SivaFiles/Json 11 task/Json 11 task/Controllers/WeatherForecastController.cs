using Json_11_task.model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Json_11_task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class weatherForecastController : ControllerBase
    {
        
        [HttpGet("GetDepartment")]
        // object = base type of all other types
        public object GetDepartment()
        {
            string jsondata = "{\"id\": 22,\"name\":\"siva\" }";

            Department deptList = JsonConvert.DeserializeObject<Department>(jsondata);


            Console.WriteLine("Department id is: {0}", deptList.Id);
            Console.WriteLine("Department Fristname is: {0}", deptList.Name);
            // Department rep = await _GetDepartment.Department();
            return (deptList);
        }

        [HttpGet("GetDepartment2")]
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

            string str = @"H:\Sivallingam\SivaFiles\Json 11 task\Json 11 task\jsconfig2.json";
            System.IO.File.WriteAllText(str,rep1);
            return rep1;
        }

        [HttpGet("Getname3")]
        public object Getname3()
        {
            string man = @"H:\Sivallingam\SivaFiles\Json 11 task\Json 11 task\jsconfig2.json";
            System.IO.File.ReadAllText(man);
            Department input = JsonConvert.DeserializeObject<Department>(man);
            //Console.WriteLine($"name={input} ");
            return input;
        }

    }
}
