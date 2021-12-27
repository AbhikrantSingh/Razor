using System;
using System.Collections.Generic;
using System.Text;

namespace RazorLearningTutorials
{
    public class Pagination
    {
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 5;

        public int TotalPage => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
    }
}
