using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class Bridgeone
    {
        //static void Main()
        //{
        //    Abstraction1 ab = new RefinedAbstraction1();

        //    ab.Implementor = new ConcreteTypeA();
        //    ab.Operation();


        //    ab.Implementor = new ConcreteTypeB();
        //    ab.Operation();

        //    Console.ReadKey();
        //}

    }


    class Abstraction1
    {
        protected Implementer implementer;

        public Implementer Implementor
        {
            set { implementer = value; }
        }
        
        public virtual void Operation()
        {
            implementer.Operation();
        }
    }

    abstract class Implementer
    {
        public abstract void Operation();
    }

    class RefinedAbstraction1 : Abstraction1
    {
        public override void Operation()
        {
            implementer.Operation();
        }
    }

    class ConcreteTypeA : Implementer
    {
        public override void Operation()
        {
            Console.WriteLine("aaaaaa");
        }

    }

    class ConcreteTypeB : Implementer
    {
        public override void Operation()
        {
            Console.WriteLine("bbbbbbbbb");
        }
    }
}
