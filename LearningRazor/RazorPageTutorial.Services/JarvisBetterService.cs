﻿using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public class JarvisBetterService : IJarvisBetter
    {
        public IAITemplateComparisionRepo aITemplateComparisionRepo;

        public JarvisBetterService(IAITemplateComparisionRepo aITemplateComparisionRepo)
        {
            this.aITemplateComparisionRepo = aITemplateComparisionRepo;
        }

        public IEnumerable<JarvisBetter> GetJarvisBetterResult(int currentPage, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int GetJarvisCount()
        {
            return getJarvisList().Count;
        }

        public List<JarvisBetter> getJarvisList()
        {
            List<JarvisBetter> list1 = new List<JarvisBetter>();
            IEnumerable<ATTemplateComparisionResult> aTTTemplateComparisionResults = aITemplateComparisionRepo.getATTemplateComparisionResults();
            foreach (var res in aTTTemplateComparisionResults)
            {
                if (res.AICanonicalDiffrence.Length > 0)
                {
                    list1.Add(new JarvisBetter() { AICanonicalDiffrence = res.AICanonicalDiffrence, Docguid = res.Docguid });
                }
            }
            return list1;
        }



    }
}
