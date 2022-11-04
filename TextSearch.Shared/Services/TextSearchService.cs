using System.Text.RegularExpressions;
using TextSearch.Shared.Interfaces;

namespace TextSearch.Shared.Services
{
    public class TextSearchService : ITextSearchService
    {
        public int Search(string inputString, string searchString, bool isFullText, bool isCaseSensitive)
        {
            searchString = Regex.Escape(searchString);
            var expr = isFullText ? $"(?!\\W)\\b{searchString}(?:\\b|$)" : searchString;
            var options = isCaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase;
            return Regex.Matches(inputString, expr, options).Count;
        }
    }
}
