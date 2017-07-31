using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Composite root = new Composite("root");
        //    root.Add(new Leaf("Leaf A"));
        //    root.Remove(new Leaf("Leaf B"));

        //    Composite comp = new Composite("Composite X");
        //    comp.Add(new Leaf("Leaf XA"));
        //    comp.Remove(new Leaf("Leaf XB"));

        //    root.Add(comp);
        //    root.Add(new Leaf("Leaf C"));


        //    Leaf leaf = new Leaf("Leaf D");
        //    root.Add(leaf);
        //    root.Remove(leaf);

        //    root.Display(1);
                 

        //    Console.ReadKey();
        //}
    }

    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);

    }

    class Composite : Component
    {
        private List<Component> _childeren = new List<Component>();

        public Composite(string name):base(name)
        {

        }

        public override void Add(Component component)
        {
            _childeren.Add(component);
        }

        public override void Remove(Component component)
        {
            _childeren.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach(Component component in _childeren)
            {
                component.Display(depth + 2);
            }
        }
    }


    class Leaf: Component
    {
        public Leaf(string name): base(name)
        {

        }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

    }

}
