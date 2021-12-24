using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public class MockAITemplateComparisionResult : IAITemplateComparisionRepo
    {
        private List<ATTemplateComparisionResult> list;

        public MockAITemplateComparisionResult()
        {

            list = new List<ATTemplateComparisionResult>()
                {
                    new ATTemplateComparisionResult(){ Docguid="123321", AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid="123321", AICanonicalDiffrence="", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid="123321", AICanonicalDiffrence="", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid="123321", AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="qwertyu" }
                };
        }

        public IEnumerable<ATTemplateComparisionResult> getATTemplateComparisionResults()
        {
            return list;
        }

    }
}
