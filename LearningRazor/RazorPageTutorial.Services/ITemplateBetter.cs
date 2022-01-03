using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public interface ITemplateBetter
    {

        public int GetTemplateBetterCount();

        public List<TemplateBetter> getTemplateList();
    }
}
