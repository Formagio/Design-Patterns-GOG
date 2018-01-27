using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Base;
using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatternsGOG.CreationalPatterns.FactoryMethod
{
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
}
