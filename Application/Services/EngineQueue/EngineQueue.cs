using System.Collections.Generic;
using Application.SearchEngines;

namespace Application.Services.EngineQueue
{
    public class EngineQueue : IEngineQueue
    {
        private readonly IGoogleEngine _google;
        private readonly IBingEngine _bing;
        public EngineQueue(IGoogleEngine google, IBingEngine bing)
        {
            _bing = bing;
            _google = google;
        }

        public List<SearchEngine> Enqueue()
        {
            var EngineList = new List<SearchEngine>();
            EngineList.Add((GoogleEngine)_google);
            EngineList.Add((BingEngine)_bing);
            

            return EngineList;
        }
    }
}