namespace protectedarthmetic;
 class Program1
{
    protected int addition;
    protected int sub;
    protected int div;
    protected int multiple;
    public void arithmetic()
    {
        Console.WriteLine("addition : {0}", addition);
        Console.WriteLine("sub : {0}", sub);
        Console.WriteLine("div : {0}", div);
        Console.WriteLine("multiple : {0}", multiple);
    }
}
class Program :Program1
{
   public  static void Main(string[] args, int value, int value1,int value2,int value3)
   {
        Program u = new Program();
        u.addition = value;
        u.sub = value1;
        u.div = value2;
        u.multiple = value3;
        Console.WriteLine(" \npress enter key to exit..");
        Console.ReadLine();
   }
}
