namespace jsonfile1
{
    public class Lad
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public MyDate DateOfBirth { get; set; }
        public object Formatting { get; internal set; }
    }
}