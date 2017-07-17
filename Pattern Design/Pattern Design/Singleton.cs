using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class Singleton
    {
        //static void Main()
        //{
        //    SingletonOne s1 = SingletonOne.Instance();
        //    SingletonOne s2 = SingletonOne.Instance();

 
        //    if (s1 == s2)
        //    {
        //        Console.WriteLine("Objects are the same instance");
        //    }

         
        //    Console.ReadKey();
        //}
    }

    class SingletonOne
    {
        private static SingletonOne _instance;
        

        protected SingletonOne()
        {
        }

        public static SingletonOne Instance()
        {

            if (_instance == null)
            {
                _instance = new SingletonOne();
            }

            return _instance;
        }
    }
}
