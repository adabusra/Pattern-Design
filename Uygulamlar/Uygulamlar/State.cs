using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    //class StateApp
    //{
    //    //static void Main()
    //    //{
    //    //    ContextState c = new ContextState(new ConcreteStateA());


    //    //    c.Request();
    //    //    c.Request();
    //    //    c.Request();
    //    //    c.Request();


    //    //    Console.ReadKey();
    //    //}

    //}

    //abstract class State
    //{
    //    public abstract void Handle(ContextState context);
    //}

    //class ConcreteStateA : State
    //{
    //    public override void Handle(ContextState context)
    //    {
    //        context.State = new ConcreteStateB();
    //    }
    //}

    //class ConcreteStateB: State
    //{
    //    public override void Handle(ContextState context)
    //    {
    //        context.State = new ConcreteStateA();
    //    }
    //}

    //class ContextState
    //{
    //    private State _state;

    //    public ContextState(State state)
    //    {
    //        this._state = state;
    //    }

    //    public State State
    //    {
    //        get { return _state; }
    //        set
    //        {
    //            _state = value;
    //            Console.WriteLine("State: " + _state.GetType().Name);
    //        }
    //    }

    //    public void Request()
    //    {
    //        _state.Handle(this);
    //    }
    //}
}
