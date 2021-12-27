using System;

namespace RazorLearningTutorials
{
    internal class BindPropertyAttribute : Attribute
    {
        public bool SupportsGet { get; set; }
    }
}