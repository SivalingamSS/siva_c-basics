/*using System.Text.Json.Serialization.Metadata;

namespace Summa
{
    interface sub
    {
        public void m1();
    }
    interface sub1
    {
        public void m1();
    }

    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public  void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal,sub
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        public void m1()
        {
            Console.WriteLine("seran");
        }

        public virtual void sleep()
        {
            Console.WriteLine("YYY");
        }

        public class a
        {
            public void m1(int a,string d)
            {
                Console.WriteLine(a+d);
            }
            public void m1(string a,int b)
            {
                Console.WriteLine(a + b);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
}*/

using System;
public abstract class Animal
{
    public  virtual void  eat(string a)
    {
        Console.WriteLine("Eating...");
    }
    public  virtual void eat(int b)
    {
        Console.WriteLine("Eatings...");
    }
}
 public class Dog : Animal
{
    public override void eat(string a)
    {
        Console.WriteLine("Eating bread...");
    }
}
public class TestOverriding
{
    public static void Main()
    {
        Dog d = new Dog();
        d.eat("seran");
        d.eat(1);
    }
}