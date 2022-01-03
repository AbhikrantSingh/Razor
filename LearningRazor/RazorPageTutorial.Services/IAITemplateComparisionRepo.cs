using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public interface IAITemplateComparisionRepo
    {
        IEnumerable<ATTemplateComparisionResult> getATTemplateComparisionResults();
        public int GetTemplateBetterCount();
    }
}
