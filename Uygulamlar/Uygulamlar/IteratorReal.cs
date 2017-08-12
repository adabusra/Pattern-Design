using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class IteratorReal
    {

        static void Main()
        {
          
           
            Console.ReadKey();
        }
    }
    
    class Madde
    {
        private string _ad;

        public Madde(string ad)
        {
            this._ad = ad;
        }

        public string Ad
        {
            get { return _ad; }
        }
    }

    interface IAbstractCollection
    {

    }

    class Toplamak : IAbstractCollection
    {
        private ArrayList _maddeler = new ArrayList();

      
    }

    interface IAbstractYineleyici
    {
        Madde Ilk();
        Madde Ileri();
        bool Bitti { get; }
        Madde GecerliOge { get; }
    }

    class Yineleyici : IAbstractYineleyici
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Yineleyici(Collection collection)
        {
            this._collection = collection;
        }

        public Madde Ilk()
        {
            _current = 0;
            return _collection[_current] as Madde;

        }

    }

}
