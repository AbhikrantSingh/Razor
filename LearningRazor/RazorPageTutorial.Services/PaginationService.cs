using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPageTutorial.Services
{
    public class PaginationService : IPaginationService , ITemplateBetter, IJarvisBetter
    {

        public IAITemplateComparisionRepo aITemplateComparisionRepo;

        public IEnumerable<ATTemplateComparisionResult> aTTTemplateComparisionResults { get; set; }

        public IEnumerable<JarvisBetter> list { get; set; }

        public IEnumerable<TemplateBetter> templateBetterlist { get; set; }


        List<JarvisBetter> list1 = new List<JarvisBetter>();

        List<TemplateBetter> templatelist1 = new List<TemplateBetter>();

        public PaginationService(IAITemplateComparisionRepo iAITemplateComparisionRepo)
        {
            this.aITemplateComparisionRepo = iAITemplateComparisionRepo;
          
            OnGet();
           
        }

        public int  GetCount()
        {
            return aTTTemplateComparisionResults.Count();
        }

        public List<ATTemplateComparisionResult> GetPaginatedResult(int currentPage, int pageSize)
        {
            Console.WriteLine(currentPage+"currentPAge");
            List<ATTemplateComparisionResult> list = new List<ATTemplateComparisionResult>();
            list=aTTTemplateComparisionResults.OrderBy(d => d.Docguid).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            Console.WriteLine( list[1].Docguid);
            return list;
        }
       private void OnGet()
        {

            aTTTemplateComparisionResults = aITemplateComparisionRepo.getATTemplateComparisionResults();
            list = getJarvisList();
            templateBetterlist = getTemplateList();
        }

        public IEnumerable<JarvisBetter> GetJarvisBetterResult(int currentPage, int pageSize)
        {
           
            list1 = list.OrderBy(d => d.Docguid).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return list1;
        }

        public int GetJarvisCount()
        {
            return list.Count();
        }
        public List<JarvisBetter> getJarvisList()
        {
            List<JarvisBetter> list1 = new List<JarvisBetter>();

            foreach (var res in aTTTemplateComparisionResults)
            {
                if (res.AICanonicalDiffrence.Length > 0)
                {
                    list1.Add(new JarvisBetter() { AICanonicalDiffrence = res.AICanonicalDiffrence, Docguid = res.Docguid });
                }
            }
            return list1;
        }


        public List<TemplateBetter> getTemplateList()
        {
            List<TemplateBetter> list1 = new List<TemplateBetter>();

            foreach (var res in aTTTemplateComparisionResults)
            {
                if (res.AICanonicalDiffrence.Length > 0)
                {
                    list1.Add(new TemplateBetter() { OrginalCanonicalDiffrence = res.OrginalCanonicalDiffrence, Docguid = res.Docguid });
                }
            }
            return list1;
        }


        public IEnumerable<TemplateBetter> GetTemplateBetterResult(int currentPage, int pageSize)
        {
            templatelist1 = templateBetterlist.OrderBy(d => d.Docguid).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return templatelist1;
        }

        public int GetTemplateBetterCount()
        {
            return templateBetterlist.Count();
        }
    }
}