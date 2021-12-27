using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTutorial.Services;
using RazorLearningTutorials;
using System.Text;
using System.Data;
using ClosedXML.Excel;
using System.IO;

namespace LearningRazor.Pages.AIvsTemplate
{
    public class IndexModel : PageModel
    {
        /*
          [BindProperty(SupportsGet = true)]
          public int CurrentPage { get; set; } = 1;
          public int Count { get; set; }
          public int PageSize { get; set; } = 5;

          public int TotalPage => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
          */
        public Pagination pagination1 = new Pagination();
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public List<ATTemplateComparisionResult> Data { get; set; }

        public readonly IPaginationService paginationService;


        
        public readonly IAITemplateComparisionRepo iAITemplateComparisionRepo;
        public IEnumerable<ATTemplateComparisionResult> aTTTemplateComparisionResults { get; set; }
        public IndexModel(IAITemplateComparisionRepo iAITemplateComparisionRepo, IPaginationService paginationService )
        {

            this.iAITemplateComparisionRepo = iAITemplateComparisionRepo;
            this.paginationService = paginationService;
            pagination1 = new Pagination();
 
        }


        public async Task OnGetAsync()
        {
            pagination1.CurrentPage = CurrentPage;
            aTTTemplateComparisionResults = iAITemplateComparisionRepo.getATTemplateComparisionResults();
            Data =  paginationService.GetPaginatedResult(pagination1.CurrentPage, pagination1.PageSize);

            pagination1.Count =  paginationService.GetCount();
            Console.WriteLine(pagination1.Count);
        }

        public FileContentResult OnPostExport()
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Docguid"),
                                                    new DataColumn("AIDiffrence"),
                                                    new DataColumn("OriginalDiifrence"),
                                                    new DataColumn("Result")});
            var result = iAITemplateComparisionRepo.getATTemplateComparisionResults();
            foreach (var res in result)
            {
                dt.Rows.Add(res.Docguid, res.AICanonicalDiffrence, res.OrginalCanonicalDiffrence, res.Result);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");
                }
            }
        }
        /* public async Task OnGetAsync()
         {
             Data = await paginationService.GetPaginatedResult(CurrentPage, PageSize);
             Count = await paginationService.GetCount();
         }
        */
    }
}
