using System;
using System.Collections.Generic;
using System.Text;

namespace RazorLearningTutorials
{
    public class ATTemplateComparisionResult
    {

        public string OrginalCanonicalDiffrence { get; set; }
        public string AICanonicalDiffrence { get; set; }
        public int Docguid { get; set; }

        public string Result { get; set; }

        /*public ATTemplateComparisionResult(string orginalCanonicalDiffrence, string aICanonicalDiffrence, string docguid)
        {
            OrginalCanonicalDiffrence = orginalCanonicalDiffrence;
            AICanonicalDiffrence = aICanonicalDiffrence;
            Docguid = docguid;
        }*/

       
    }
}
