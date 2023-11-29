
using System.ComponentModel.DataAnnotations;

namespace Sampleapi.Modal
{
    public class modal
    {
        [Key]
        public int PatientID { get; set; }
        public string? name { get; set; }
        public int? phoneNo { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
    }
}
