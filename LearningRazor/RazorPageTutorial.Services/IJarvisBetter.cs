using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public interface IJarvisBetter
    {
        IEnumerable<JarvisBetter> GetJarvisBetterResult(int currentPage, int pageSize);
        public int GetJarvisCount();

    }
}
