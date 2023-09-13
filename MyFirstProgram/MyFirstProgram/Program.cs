using System;
namespace NameSpace1
{
    public class MyClassOne
    {
        public void Greet()
        {
            Console.WriteLine("Hello From My Class One");
        }
    }
}
namespace NameSpace2
{
    public class MyClassTwo
    {
        public void Greet()
        {
            Console.WriteLine("Hello From My Class Two");
        }
    }
}
//main
namespace NameSpaceDemo
{
    public class MyFirstProgram
    {
        public static void Main()
        {
            NameSpace1.MyClassOne obj1 = new NameSpace1.MyClassOne();
            NameSpace2.MyClassTwo obj2 = new NameSpace2.MyClassTwo();

            obj1.Greet();
            obj2.Greet();
        }
    }
}