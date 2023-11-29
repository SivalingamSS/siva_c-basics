using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonfile1.model
{
    class student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
       /* public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        */
    }
    class Department
    {
        public List<student> csc;
       
    }
}
