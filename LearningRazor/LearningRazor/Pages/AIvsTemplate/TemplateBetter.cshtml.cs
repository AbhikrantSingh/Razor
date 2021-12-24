using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLearningTutorials;
using RazorPageTutorial.Services;

namespace LearningRazor.Pages.AIvsTemplate
{
    public class TemplateBetterModel : PageModel
    {
        public readonly IAITemplateComparisionRepo iAITemplateComparisionRepo;
        public IEnumerable<ATTemplateComparisionResult> aTTTemplateComparisionResults { get; set; }

        public TemplateBetterModel(IAITemplateComparisionRepo iAITemplateComparisionRepo)
        {
            this.iAITemplateComparisionRepo = iAITemplateComparisionRepo;
        }


        
        public void OnGet()
        {
            aTTTemplateComparisionResults = iAITemplateComparisionRepo.getATTemplateComparisionResults();//  mparisionRepo.getATTemplateComparisionResults();

        }
    }
}
