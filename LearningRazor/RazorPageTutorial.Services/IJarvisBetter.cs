using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
    public interface IJarvisBetter
    {
        public int GetJarvisCount();

        public List<JarvisBetter> getJarvisList();

    }
}
