using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    class trial
    {
        //static void Main()
        //{
        //    //Document[] documents = new Document[3];

        //    //documents[0] = new Resume();
        //    //documents[1] = new Report();
        //    //documents[2] = new Return();

        //    //foreach(Document document in documents)
        //    //{
        //    //    Console.WriteLine("\n" + document.GetType().Name + "--");
        //    //    foreach(Page page in document.Pages)
        //    //    {
        //    //        Console.WriteLine(" " + page.GetType().Name);
        //    //    }
        //    //}
        //    //Console.ReadKey();
        //}
        abstract class Page
        {

        }

        class IntroductionPage : Page
        {

        }
        class ConclusionPage : Page
        {

        }

        class SkillsPage : Page
        {

        }

        class EducationPage : Page
        {

        }
        class ExperiencePage : Page
        {

        }

        class ResultsPage : Page
        {

        }
        class CocllusionPage : Page
        {

        }
        class SummaryPage : Page
        {

        }
        class BibliographyPage : Page
        {

        }

        abstract class Document
        {
            private List<Page> _pages = new List<Page>();

            public Document()
            {
                this.CreatePages();
            }

            public List<Page> Pages
            {
                get { return _pages; }
            }

            public abstract void CreatePages();
        }
        class Resume : Document
        {
            public override void CreatePages()
            {
                Pages.Add(new SkillsPage());
                Pages.Add(new EducationPage());
                Pages.Add(new ExperiencePage());
            }
        }

        class Report : Document
        {
            public override void CreatePages()
            {
                Pages.Add(new IntroductionPage());
                Pages.Add(new ResultsPage());
                Pages.Add(new ConclusionPage());
                Pages.Add(new SummaryPage());
                Pages.Add(new BibliographyPage());
            }
        }
        class Return : Document
        {
            public override void CreatePages()
            {
                Pages.Add(new IntroductionPage());
                Pages.Add(new ResultsPage());
                Pages.Add(new ConclusionPage());
                Pages.Add(new SummaryPage());
            }

        }


    }

}

