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
        public readonly IAITemplateComparisionRepo iAITemplateComparisionRepo;
        public IEnumerable<ATTemplateComparisionResult> aTTTemplateComparisionResults { get; set; }
        public IndexModel(IAITemplateComparisionRepo iAITemplateComparisionRepo)
        {
            this.iAITemplateComparisionRepo = iAITemplateComparisionRepo;
        }

        public void OnGet()
        {
            aTTTemplateComparisionResults = iAITemplateComparisionRepo.getATTemplateComparisionResults();//  mparisionRepo.getATTemplateComparisionResults();

        }

        public FileContentResult OnPostExport()
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Docguid"),
                                                    new DataColumn("AIDiffrence"),
                                                    new DataColumn("OriginalDiifrence"),
                                                    new DataColumn("Result")});
            var result = iAITemplateComparisionRepo.getATTemplateComparisionResults();
            foreach(var res in result)
            {
                dt.Rows.Add(res.Docguid, res.AICanonicalDiffrence, res.OrginalCanonicalDiffrence, res.Result);          
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.csv");
                }
            }
        }

    }
}
/*
 
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
}
 */