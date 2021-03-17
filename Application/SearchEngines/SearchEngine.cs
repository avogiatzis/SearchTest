using Application.Services.HTMLReader;
using Application.Services.SearchParser;

namespace Application.SearchEngines
{
    public abstract class SearchEngine
    {
        public virtual string Name { get; set; }
        protected readonly IHTMLReader _reader;
        protected readonly ISearchParser _parser;
        protected SearchEngine(IHTMLReader reader, ISearchParser parser)
        {
            _parser = parser;
            _reader = reader;

        }
        public abstract string GetOccurences(string url, string keyword);
    }
}