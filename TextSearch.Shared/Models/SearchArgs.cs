using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextSearch.Shared.Models
{
    public class SearchArgs
    {
        public string InputString { get; set; }
        public string SearchString { get; set; }
        public bool IsFullText { get; set; }
        public bool IsCaseSensitive { get; set; }
        public SearchArgs(string inputString, string searchString, bool isFullText, bool isCaseSensitive)
        {
            InputString = inputString;
            SearchString = searchString;
            IsFullText = isFullText;
            IsCaseSensitive = isCaseSensitive;
        }
    }
}
