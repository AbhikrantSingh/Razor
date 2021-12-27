using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLearningTutorials;

namespace LearningRazor.Pages.AIvsTemplate
{
    public class PaginationModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 5;

        public int TotalPage => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public List<ATTemplateComparisionResult> Data { get; set; }

        public void OnGet()
        {
        }
    }
}
