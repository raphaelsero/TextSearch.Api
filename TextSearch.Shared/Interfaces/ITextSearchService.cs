using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSearch.Shared.Interfaces
{
    public interface ITextSearchService
    {
        int Search(string inputString, string searchString, bool isFullText, bool isCaseSensitive);
    }
}
