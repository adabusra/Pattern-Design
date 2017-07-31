using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class ComponentTwo
    {
        static void Main()
        {
            KompoziteEleman root = new KompoziteEleman("Picture");
            root.Ekle(new IlkelEleman("Kırmizi satır"));
            root.Ekle(new IlkelEleman("Mavi satır"));
            root.Ekle(new IlkelEleman("Yeşil Kutu"));

            KompoziteEleman comp = new KompoziteEleman("İki Daire");
            comp.Ekle(new IlkelEleman("Siyah Daire"));
            comp.Ekle(new IlkelEleman("Beyaz Daire"));



            root.Ekle(comp);


            IlkelEleman ie = new IlkelEleman("Sarı satır");
            root.Ekle(ie);
            root.Duzenle(ie);

            root.Ekran(1);

            Console.ReadKey();
        }
        
    }

    abstract class CizimElemani
    {
        protected string _ad;

        public CizimElemani(string ad)
        {
            this._ad = ad;

        }

        public abstract void Ekle(CizimElemani d);
        public abstract void Duzenle(CizimElemani d);
        public abstract void Ekran(int derinlik);
    }

    class IlkelEleman : CizimElemani
    {
        public IlkelEleman(string ad): base(ad)
        {

        }
        public override void Ekle(CizimElemani c)
        {
            Console.WriteLine("Çizim elemanı eklenemiyor");
        }
        public override void Duzenle(CizimElemani c)
        {
            Console.WriteLine("Çizim elemanı düzenlenemiyor");

        }
        public override void Ekran(int derinlik)
        {
            Console.WriteLine(new string('-', derinlik) + " " + _ad);
        }
    }

    class KompoziteEleman: CizimElemani
    {
        private List<CizimElemani> elemanlar = new List<CizimElemani>();

        public KompoziteEleman(string ad): base(ad)
        {
        }

        public override void Ekle(CizimElemani d)
        {
            elemanlar.Add(d);
        }
        public override void Duzenle(CizimElemani d)
        {
            elemanlar.Remove(d);
        }
        public override void Ekran(int derinlik)
        {
            Console.WriteLine(new string('-', derinlik) + "+ " + _ad);

            foreach(CizimElemani d in elemanlar)
            {
                d.Ekran(derinlik + 2);
            }
        }
    }
}
