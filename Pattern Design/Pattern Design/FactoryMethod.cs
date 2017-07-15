using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class FactoryMethod
    {
        //static void Main()
        //{
        //    Document[] documents = new Document[3];

        //    documents[0] = new Ege();
        //    documents[1] = new IcAnadolu();
        //    documents[2] = new Karadeniz();
        //    documents[3] = new Marmara();


        //    foreach (Document document in documents)
        //    {
        //        Console.WriteLine("\n" + document.GetType().Name + "--");
        //        foreach (Universite univer in document.Universitem)
        //        {
        //            Console.WriteLine(" " + univer.GetType().Name);
        //        }

        //    }
        //    Console.ReadKey();
        //}

        class Universite
        {

        }

        class SAU : Universite
        {

        }

        class KATU : Universite
        {


        }

        class MARMARA : Universite
        {

        }

        class OSMANGAZI : Universite
        {

        }

        class ANKARA : Universite
        {

        }

        class TOBB : Universite
        {

        }

        class EGE : Universite
        {

        }

        class CUMHURIYET : Universite
        {

        }

        class IZMIR : Universite
        {

        }
        abstract class Document
        {
            private List<Universite> _universitem = new List<Universite>();

            public Document()
            {
                this.olusturUniversite();
            }

            public List<Universite> Universitem
            {
                get { return _universitem; }
            }

            public abstract void olusturUniversite();
        }

        class Ege : Document
        {
            public override void olusturUniversite()
            {
                Universitem.Add(new EGE());
                Universitem.Add(new IZMIR());
            }
        }
        class IcAnadolu : Document
        {
            public override void olusturUniversite()
            {
                Universitem.Add(new CUMHURIYET());
                Universitem.Add(new ANKARA());
                Universitem.Add(new TOBB());
            }
        }
        class Marmara : Document
        {
            public override void olusturUniversite()
            {
                Universitem.Add(new SAU());
                Universitem.Add(new OSMANGAZI());
            }

        }
        class Karadeniz : Document
        {
            public override void olusturUniversite()
            {
                Universitem.Add(new KATU());
                Universitem.Add(new ANKARA());
            }
        }


    }

   
}
