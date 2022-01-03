using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public class AITemplateComparisionService : IAITemplateComparisionRepo
    {
        public IAITemplateComparisionRepo aITemplateComparisionRepo;

        public AITemplateComparisionService(IAITemplateComparisionRepo aITemplateComparisionRepo)
        {
            this.aITemplateComparisionRepo = aITemplateComparisionRepo;
        }

        public int GetTemplateBetterCount()
        {
            return getAllResultList().Count;
        }
        public List<ATTemplateComparisionResult> getAllResultList()
        {
            return (List<ATTemplateComparisionResult>)aITemplateComparisionRepo.getATTemplateComparisionResults();
        
        }




        public IEnumerable<ATTemplateComparisionResult> getATTemplateComparisionResults()
        {

            return (List<ATTemplateComparisionResult>)aITemplateComparisionRepo.getATTemplateComparisionResults();
        }
    }
}
