using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RazorPageTutorial.Services
{
    public interface IPaginationService
    {
        public List<ATTemplateComparisionResult> GetPaginatedResult(int currentPage, int pageSize = 10);
        public int GetCount();
        IEnumerable<JarvisBetter> GetJarvisBetterResult(int currentPage, int pageSize);
        public IEnumerable<TemplateBetter> GetTemplateBetterResult(int currentPage, int pageSize);
  

        //   public List<ATTemplateComparisionResult> GetJarvidResult(int currentPage, int pageSize = 10);

    }
}