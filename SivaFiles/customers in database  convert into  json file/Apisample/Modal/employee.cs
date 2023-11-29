using System.ComponentModel.DataAnnotations;

namespace Apisample.Modal
{
    public class Employee
    {
        [Key]
        public int customersid  { get; set; }
        public string? customersname { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public string? CITY { get; set; }
        public string? CITYNAME { get; set; }
    }
}
