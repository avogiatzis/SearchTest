using System.Collections.Generic;

namespace Domain
{
    public class SearchResult
    {
        public SearchResult(string results, string engine)
        {
            Results = results;
            Engine = engine;
        }

        public string Results { get; set; }
        public string Engine { get; set; }
    }
}