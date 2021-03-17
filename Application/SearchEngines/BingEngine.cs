
using System.Linq;
using System.Text.RegularExpressions;
using Application.Services.HTMLReader;
using Application.Services.SearchParser;

namespace Application.SearchEngines
{
    public class BingEngine : SearchEngine, IBingEngine
    {
        public override string Name { get{return "Bing";} }
        public BingEngine(IHTMLReader reader, ISearchParser parser) : base(reader, parser)
        {
        }

        public override string GetOccurences(string url, string keyword)
        {
            var mainResults = _reader.Read("Bing", keyword);
            var rx = new Regex("<li class=\"b_algo\">(.*?)</cite>");
            var matches = rx.Matches(mainResults);
            var references = rx.Matches(mainResults).Cast<Match>().Select(m => m.Value).Take<string>(50).ToArray();
            return _parser.GetResults(references, url);
        }
    }
}