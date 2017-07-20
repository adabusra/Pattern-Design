using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class bahce
    {
        static void Main()
        {
            bilesik bilinmeyen = new bilesik("bilinmeyen");
            bilinmeyen.ekran();


            bilesik su = new zenginBilesik("su");
            su.ekran();

            bilesik benzin = new zenginBilesik("benzin");
            benzin.ekran();

            Console.ReadKey();
        }


    }

    class bilesik
    {
        protected string _kimyasal;
        protected float _noktaatmanoktasi;
        protected float _erimenoktasi;
        protected double _molekuleragirlik;
        protected string _molekulerformul;

        public bilesik( string kimyasal)
        {
            this._kimyasal= kimyasal;
        }

        public virtual void ekran()
        {
            Console.WriteLine("\nBileşik: {0}------------");
        }

    }

    class zenginBilesik : bilesik
    {
        private kimyasalVeriBankasi _banka;

        public zenginBilesik(string ad) : base(ad)
        {

        }


        public override void ekran()
        {
            _banka = new kimyasalVeriBankasi();

            _noktaatmanoktasi = _banka.KritikNoktayiAl(_kimyasal, "B");
            _erimenoktasi = _banka.KritikNoktayiAl(_kimyasal, "M");
            _molekuleragirlik = _banka.MolekulAgirligiAlin(_kimyasal);
            _molekulerformul = _banka.MolekuerYapiyiAl(_kimyasal);

            base.ekran();

            Console.WriteLine(" Formula: {0}", _molekulerformul);
            Console.WriteLine(" Weight: {0}", _molekuleragirlik);
            Console.WriteLine(" Melting Pt: {0}", _erimenoktasi);
            Console.WriteLine(" Boiling Pt: {0}", _noktaatmanoktasi);

        }
    }

    class kimyasalVeriBankasi
    {
        public float KritikNoktayiAl(string bilesik, string nokta)
        {
            if (nokta == "M")
            {
                switch (bilesik.ToLower())
                {
                    case "su": return 0.0f;
                    case "benzin": return 5.5f;
                    case "ethonol": return -114.5f;
                    default: return 0f;
                }
            }
            else
            {
                switch (bilesik.ToLower())
                {
                    case "su": return 0.0f;
                    case "benzin": return 5.5f;
                    case "ethonol": return -114.5f;
                    default: return 0f;
                }
            }
        }

        public string MolekuerYapiyiAl(string bilesik)
        {
            switch (bilesik.ToLower())
            {
                case "su": return "H2O";
                case "benzin": return "C6H6";
                case "ethonol": return "C2H5OH";
                default: return "";
            }
        }

        public double MolekulAgirligiAlin(string bilesik)
        {
            switch (bilesik.ToLower())
            {
                case "su": return 18.05;
                case "benzin": return 78.1134;
                case "ethonol": return 46.06388;
                default: return 0d;
            }
        }
    }
}

