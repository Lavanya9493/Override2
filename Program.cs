using System;

namespace Override2
{
    
    class Base
    {
        public virtual void Print()
        {
            Console.WriteLine("Base.Print()");
        }
    }
    class Derived:Base
    {
        public override void Print()
        {
            Console.WriteLine("Derived.Print()");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Derived d=new Derived();
            d.Print();
            Base b=new Derived();
            b.Print();
        }
    }
}
