using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

           DerivedClass d1 = new DerivedClass();
          //  DerivedClass d1 = new DerivedClass();
            // d1.Display1(10);
            //  d1.Display2();
            BaseClass b1 = new BaseClass();
            //   b1.Display2();  
            b1.Display3();
            Console.ReadLine();
        }
    }

     class BaseClass
    {
        public int i;
        
         public void Display1()
        {
            Console.WriteLine("for method overloding baseclass"); ;

        }
         public void Display2()
        {
            Console.WriteLine("for method overriding baseclass"); ;

        }
        public virtual void Display3()
        {
            Console.WriteLine("for method overriding baseclass "); ;

        }



    }
      class DerivedClass :BaseClass
    {
        public int j;
          
          

        public void Display1(int i)
        {
            Console.WriteLine("for method overloding Derived class "); ;

        }
        public new void Display2()
        {
            Console.WriteLine("for method hiding Derived "); ;

        }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public  void Display3()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            Console.WriteLine("for method overriding Derived "); ;

        }
    }
}














