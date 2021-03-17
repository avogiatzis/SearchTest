using System.Collections.Generic;
using Application.SearchEngines;

namespace Application.Services.EngineQueue
{
    public interface IEngineQueue
    {
        public List<SearchEngine> Enqueue();
    }
}