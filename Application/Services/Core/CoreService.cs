using System.Collections.Generic;

using Application.Services.EngineQueue;
using Domain;

namespace Application.Services.Core
{
    public class CoreService : ICoreService
    {
        private readonly IEngineQueue _queue;
        public CoreService(IEngineQueue queue)
        {
            _queue = queue;
        }
        public List<SearchResult> GetSearchResults(string url, string keyword)
        {
            var resultList = new List<SearchResult>();
            var engineQueue = _queue.Enqueue();
            if (!string.IsNullOrEmpty(url))
            {
                foreach (var engine in engineQueue)
                {
                    resultList.Add(new SearchResult(engine.GetOccurences(url, keyword), engine.Name));
                }
            }

            return resultList;
        }

    }
}