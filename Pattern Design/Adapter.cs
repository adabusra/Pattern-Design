using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class Unit
    {
        //static void Main()
        //{
        //    Target target = new Adapter();
        //    target.Request();

        //    Console.ReadKey();
        //}

    }

    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    class Adapter: Target
    {
        private Adaptee _adapte = new Adaptee();

        public override void Request()
        {
            _adapte.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called specified");
        }
    }
  
}
