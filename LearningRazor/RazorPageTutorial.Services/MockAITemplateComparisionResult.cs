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
                    new ATTemplateComparisionResult(){ Docguid=1, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=2, AICanonicalDiffrence="", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=3, AICanonicalDiffrence="", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=4, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=5, AICanonicalDiffrence="", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=6, AICanonicalDiffrence="", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=7, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=8, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=9, AICanonicalDiffrence="", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=10, AICanonicalDiffrence="", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=11, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=12, AICanonicalDiffrence="", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=13, AICanonicalDiffrence="", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=15, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=15, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=16, AICanonicalDiffrence="", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=17, AICanonicalDiffrence="", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=18, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="qwertyu" },
                    new ATTemplateComparisionResult(){ Docguid=19, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="" },
                    new ATTemplateComparisionResult(){ Docguid=20, AICanonicalDiffrence="Canonical name:purchase order[1]", OrginalCanonicalDiffrence="" }

            };
        }

        public IEnumerable<ATTemplateComparisionResult> getATTemplateComparisionResults()
        {
            return list;
        }

    }
}