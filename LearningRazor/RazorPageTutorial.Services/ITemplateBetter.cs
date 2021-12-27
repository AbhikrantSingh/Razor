using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public interface ITemplateBetter
    {
        public IEnumerable<TemplateBetter> GetTemplateBetterResult(int currentPage, int pageSize);
        public int GetTemplateBetterCount();
    }
}
