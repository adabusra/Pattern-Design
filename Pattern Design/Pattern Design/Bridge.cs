using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class bridge
    {
        static void Main()
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();



            Console.ReadKey();
       
        }
    }

    class Abstraction
    {
        protected Implementor implementor;
        
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    abstract class Implementor
    {
        public abstract void Operation();

    }
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }

    }

    class ConcreteImplementorA: Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA");
        }

    }
    
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB");
        }
    } 
}
