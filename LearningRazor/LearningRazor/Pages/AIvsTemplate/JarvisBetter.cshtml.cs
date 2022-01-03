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
    public class JarvisBetterModel : PageModel
    {

        public  Pagination pagination=new Pagination();
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public List<JarvisBetter> Data { get; set; }


        

        public readonly IPaginationService paginationService;


        public readonly IJarvisBetter jarvisService;
        public JarvisBetterModel( IJarvisBetter jarvisService, IPaginationService paginationService)
        {

            this.jarvisService = jarvisService;
            this.paginationService = paginationService;

    }


        public async Task OnGetAsync()
        {
            pagination.CurrentPage = CurrentPage;
            Data = (List<JarvisBetter>)jarvisService.GetJarvisBetterResult(pagination.CurrentPage, pagination.PageSize);

            pagination.Count = jarvisService.GetJarvisCount();
           
        }


    }
}
