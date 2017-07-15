using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class Prototype
    {
        //static void Main()
        //{
        //    ConcretePrototype1 p1 = new ConcretePrototype1("I");
        //    ConcretePrototype2 c1 = (ConcretePrototype1)p1.Clone();
        //    Console.WriteLine("Cloned: {0}", c1.Id);

        //    ConcretePrototype1 p2 = new ConcretePrototype1("II");
        //    ConcretePrototype2 c2 = (ConcretePrototype1)p1.Clone();
        //    Console.WriteLine("Cloned: {0}", c2.Id);

        //    Console.ReadKey();


        //}

        abstract class Prototype
        {
            private string _id;

            public Prototype(string id)
            {
                this._id = id;
            }

            public string Id
            {
                get { return _id; }
            }
            public abstract Prototype Clone();

        }

        class ConcretePrototype1: Prototype
        {

            public ConcretePrototype1(string id): base(id)
            {

            }

            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }
        class ConcretePrototype2: Prototype
        {
            public ConcretePrototype2(string id): base(id)
            {

            }

            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }
    }
}
