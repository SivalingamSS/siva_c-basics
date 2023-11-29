namespace siva;
class A
{
    public void add()
    {
        Console.WriteLine("siva");

    }
}
class B : A
{
    public void remove()
    {
        Console.WriteLine("kapilan");
    }
}
class c : B
{
    public void remover()
    {
        Console.WriteLine("kapilan");
    }
}
 class program1 
{
    public static void Main(string[] args)
    {
        c ch = new c();
       ch.add();
        ch.remove();
        ch.remover();
    }
}
