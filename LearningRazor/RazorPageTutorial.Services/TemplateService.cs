using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public class TemplateService : ITemplateBetter
    {
        public IAITemplateComparisionRepo aITemplateComparisionRepo;

        public TemplateService(IAITemplateComparisionRepo aITemplateComparisionRepo)
        {
            this.aITemplateComparisionRepo = aITemplateComparisionRepo;
        }

        public int GetTemplateBetterCount()
        {
            return getTemplateList().Count;
        }
        public List<TemplateBetter> getTemplateList()
        {
            List<TemplateBetter> list1 = new List<TemplateBetter>();
            IEnumerable<ATTemplateComparisionResult> aTTTemplateComparisionResults = aITemplateComparisionRepo.getATTemplateComparisionResults();

            foreach (var res in aTTTemplateComparisionResults)
            {
                if (res.AICanonicalDiffrence.Length > 0)
                {
                    list1.Add(new TemplateBetter() { OrginalCanonicalDiffrence = res.OrginalCanonicalDiffrence, Docguid = res.Docguid });
                }
            }
            return list1;
        }

        public IEnumerable<TemplateBetter> GetTemplateBetterResult(int currentPage, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
