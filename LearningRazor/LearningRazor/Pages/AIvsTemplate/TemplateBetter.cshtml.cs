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
        public Pagination pagination = new Pagination();

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;

        public List<TemplateBetter> Data { get; set; }

        public readonly ITemplateBetter templateBetterService;
        public readonly IPaginationService paginationService;


        public TemplateBetterModel(ITemplateBetter templateBetter, IPaginationService paginationService)
        {

            this.templateBetterService = templateBetter;
            this.paginationService = paginationService;
        }


        public async Task OnGetAsync()
        {
            Data = templateBetterService.getTemplateList();

        }
    }
}