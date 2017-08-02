using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class Facade
    {
        //static void Main()
        //{
        //    Facadee facede = new Facadee();
        //    facede.MethodA();
        //    facede.MethodB();


        //    Console.ReadKey();
        //}
    }

    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine(" SubSytemOne Method");
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine(" SubSystemTwo Method");
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine(" SubSystemThree Method");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine(" SubSystemFour Method");
        }
    }

    class Facadee
    {
        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

        public Facadee()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA()------- ");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ------- ");
            _two.MethodTwo();
            _three.MethodThree();
        }
    }
}
