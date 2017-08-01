using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class Decorator
    {
        //static void Main()
        //{
        //    ConcreteComponent c = new ConcreteComponent();
        //    ConcreteDecoratorA d1 = new ConcreteDecoratorA();
        //    ConcreteDecoratorB d2 = new ConcreteDecoratorB();

        //    d1.SetComponent(c);
        //    d2.SetComponent(d1);
        //    d2.Operation();

        //    Console.ReadKey();

        //}
    }

    abstract class Componentt
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Componentt
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    abstract class Decoratorr : Componentt
    {
        protected Componentt component;

        public void SetComponent(Componentt component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if(component != null)
            {
                component.Operation();
            }
        }
    }

    class ConcreteDecoratorA : Decoratorr
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Opeatiion()");

        }
    }

    class ConcreteDecoratorB : Decoratorr
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
        void AddBehavior()
        {
            Console.WriteLine("tria");
        }
    }
}
