using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class ObserverApp
    {
        //static void Main()
        //{
        //    ConcSubject s = new ConcSubject();

        //    s.Attach(new ConcObserver(s, "X"));
        //    s.Attach(new ConcObserver(s, "Y"));
        //    s.Attach(new ConcObserver(s, "Z"));

        //    s.SubjectState = "ABC";
        //    s.Notify();

        //    Console.ReadKey();
        //}
    }

    abstract class SubjectOberser
    {
        private List<Observer> _observer = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observer.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer o in _observer)
            {
                o.Update();
            }
        }
    }

    class ConcSubject: SubjectOberser
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }


    class ConcObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcSubject _subject;


        public ConcObserver(ConcSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1} ",
                _name, _observerState);
        }

        public ConcSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
  
}
