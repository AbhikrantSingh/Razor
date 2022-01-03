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

         public List<JarvisBetter> Data { get; set; }
         public readonly IJarvisBetter jarvisService;
        public JarvisBetterModel( IJarvisBetter jarvisService)
        {

            this.jarvisService = jarvisService;


    }


        public async Task OnGetAsync()
        {
            Data=jarvisService.getJarvisList();
           
        }


    }
}
