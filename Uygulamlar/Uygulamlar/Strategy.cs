using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    //class StrategyApp
    //{
    //    static void Main()
    //    {
    //        ContextStrategy context;

    //        context = new ContextStrategy(new ConcreteStrategy());
    //        context.ContextInterface();

    //        context = new ContextStrategy(new ConcreteStrategyB());
    //        context.ContextInterface();

    //        context = new ContextStrategy(new ConcreteStrategyC());
    //        context.ContextInterface();

    //        Console.ReadKey();
    //    }
    //}

    //abstract class Strategy
    //{
    //    public abstract void AlgorithmInterface();
    //}

    //class ConcreteStrategy : Strategy
    //{
    //    public override void AlgorithmInterface()
    //    {
    //        Console.WriteLine("Called ConcreteStrategyA.AlgoritmaInterface()");
    //    }
    //}

    //class ConcreteStrategyB : Strategy
    //{
    //    public override void AlgorithmInterface()
    //    {
    //        Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
    //    }
    //}

    //class ConcreteStrategyC : Strategy
    //{
    //    public override void AlgorithmInterface()
    //    {
    //        Console.WriteLine("Called ConcreteStrategy.AlgorithmInterface()");
    //    }
    //} 

    //class ContextStrategy
    //{
    //    private Strategy _strategy;

    //    public ContextStrategy(Strategy strategy)
    //    {
    //        this._strategy = strategy;
    //    }

    //    public void ContextInterface()
    //    {
    //        _strategy.AlgorithmInterface();
    //    }
    //}
}
