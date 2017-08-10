using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class InterpreterReal
    {
        //static void Main()
        //{
        //    string roman = "MCMXXVIII";
        //    Contextt contextt = new Contextt(roman);

        //    List<Expression> tree = new List<Expression>();
        //    tree.Add(new ThousandExpression());
        //    tree.Add(new HundredExpression());
        //    tree.Add(new TenExpression());
        //    tree.Add(new OneExpression());

        //    foreach(Expression exp in tree)
        //    {
        //        exp.Interpret(contextt);
        //    }

        //    Console.WriteLine("{0} = {1}", roman, contextt.Output);
        //    Console.ReadKey();
        //}
    }

    class Contextt
    {
        private string _input;
        private int _output;

        public Contextt(string input)
        {
            this._input= input;
        }

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public int Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }

    abstract class Expression
    {
        public void Interpret(Contextt contextt)
        {
            if (contextt.Input.Length == 0)
                return;

            if (contextt.Input.StartsWith(Nine()))
            {
                contextt.Output += (9 * Multipler());
                contextt.Input = contextt.Input.Substring(2);
            }
            else if (contextt.Input.StartsWith(Four()))
            {
                contextt.Output += (4 * Multipler());
                contextt.Input = contextt.Input.Substring(2);
            }
            else if (contextt.Input.StartsWith(Five()))
            {
                contextt.Output += (5 * Multipler());
                contextt.Input = contextt.Input.Substring(1);
            }

            while (contextt.Input.StartsWith(One()))
            {
                contextt.Output += (1 * Multipler());
                contextt.Input = contextt.Input.Substring(1);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multipler();
    }

    class ThousandExpression : Expression
    {
        public override string One()
        {
            return "M";
        }
        public override string Four()
        {
            return " ";
        }
        public override string Five()
        {
            return " ";
        }
        public override string Nine()
        {
            return " ";
        }
        public override int Multipler()
        {
            return 1000;
        }
    }

    class HundredExpression : Expression
    {
        public override string One()
        {
            return "C";
        }
        public override string Four()
        {
            return "CD";
        }
        public override string Five()
        {
            return "D";
        }
        public override string Nine()
        {
            return "CM";
        }
        public override int Multipler()
        {
            return 100;
        }
    }
    class TenExpression : Expression
    {
        public override string One()
        {
            return "X";
        }
        public override string Four()
        {
            return "XL";
        }
        public override string Five()
        {
            return "L";
        }
        public override string Nine()
        {
            return "XC";
        }
        public override int Multipler()
        {
            return 10;
        }
    }

    class OneExpression : Expression
    {
        public override string One()
        {
            return "I";
        }
        public override string Four()
        {
            return "IV";
        }
        public override string Five()
        {
            return "V";
        }
        public override string Nine()
        {
            return "IX";
        }
        public override int Multipler()
        {
            return 1;
        }
    }
}
