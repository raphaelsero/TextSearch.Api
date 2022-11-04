using TextSearch.Shared.Interfaces;
using TextSearch.Shared.Services;

namespace TextSearch.Tests
{
    public class Tests
    {
        ITextSearchService _textSearchService;
        public readonly string _inputString = "Coders who code don't always eat cod. Exclaimed the coder who codes CODE.";

        [SetUp]
        public void Setup()
        {
            _textSearchService = new TextSearchService();
        }

        [Test]
        public void TextSearchService_SearchStringCod_FullTextFalse_CaseSensitiveFalse_Returns6()
        {
            var result = _textSearchService.Search(_inputString, "Cod", false, false);
            Assert.True(result == 6);
        }
        [Test]
        public void TextSearchService_SearchStringdot_FullTextTrue_CaseSensitiveFalse_Returns0()
        {
            var result = _textSearchService.Search(_inputString, ".", true, false);
            Assert.True(result == 0);
        }
        [Test]
        public void TextSearchService_SearchStringcod_FullTextTrue_CaseSensitiveTrue_Returns1()
        {
            var result = _textSearchService.Search(_inputString, "cod", true, true);
            Assert.True(result == 1);
        }
        [Test]
        public void TextSearchService_SearchStringCODEdot_FullTextTrue_CaseSensitiveTrue_Returns1()
        {
            var result = _textSearchService.Search(_inputString, "CODE.", true, true);
            Assert.True(result == 1);
        }
        [Test]
        public void TextSearchService_SearchStringdontalways_FullTextTrue_CaseSensitiveTrue_Returns1()
        {
            var result = _textSearchService.Search(_inputString, "don't always", true, true);
            Assert.True(result == 1);
        }
    }
}