
using System.Linq;
using System.Text.RegularExpressions;
using Application.Services.HTMLReader;
using Application.Services.SearchParser;

namespace Application.SearchEngines
{
    public class GoogleEngine : SearchEngine, IGoogleEngine
    {

        public override string Name { get{return "Google";} }


        public GoogleEngine(IHTMLReader reader, ISearchParser parser) : base(reader, parser)
        {
        }

        public override string GetOccurences(string url, string keyword)
        {
            var mainResults = _reader.Read("Google", keyword);
            var rx = new Regex("<div class=\"r\">(.*?)</cite>");
            var matches = rx.Matches(mainResults);
            var references = rx.Matches(mainResults).Cast<Match>().Select(m => m.Value).Take<string>(50).ToArray();
            return _parser.GetResults(references, url);
        }
    }
}