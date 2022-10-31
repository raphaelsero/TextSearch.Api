using Microsoft.AspNetCore.Mvc;
using TextSearch.Shared.Interfaces;
using TextSearch.Shared.Models;

namespace TextSearch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextSearchController : ControllerBase
    {
        ITextSearchService _textSearchService;
        public TextSearchController(ITextSearchService textSearchService)
        {
            _textSearchService = textSearchService;
        }

        [HttpGet]
        // GET api/<ValuesController>
        public SearchArgs Get()
        {
            return new SearchArgs("Coders who code don't always eat cod. Exclaimed the coder who codes CODE.", "Cod", false,false);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public int Post([FromBody] SearchArgs args)
        {
            return _textSearchService.Search(args.InputString, args.SearchString, args.IsFullText, args.IsCaseSensitive);
        }
    }
}
