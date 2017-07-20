using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class Units
    {
        //static void Main()
        //{
        //    Compound unknown = new Compound("Unknown");
        //    unknown.Display();

        //    Compound water = new RichCompound("Water");
        //    water.Display();

        //    Compound benzene = new RichCompound("Benzene");
        //    benzene.Display();

        //    Compound ethanol = new RichCompound("Ethanol");
        //    ethanol.Display();
            

        //    Console.ReadKey();

        //}
    }

    class Compound
    {
        protected string _chemical;
        protected float _bolingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound( string chemial)
        {
            this._chemical = chemial;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0}-------");

        }
    }

    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        public RichCompound(string name): base (name) {

        }
        public override void Display()
        {
            _bank = new ChemicalDatabank();

            _bolingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();

            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight: {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _bolingPoint);

        }


    }

    class ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {

            if(point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.5f;
                    default: return 0f;
                }
            }
            else
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.5f;
                    case "ethanol": return 78.5f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H2O";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.05;
                case "benzene": return 78.1134;
                case "ethanol": return 46.06388;
                default: return 0d;
            }
        }
    }

}
