using System.Collections.Generic;
using Domain;

namespace Application.Services.Core
{
    public interface ICoreService
    {
        public List<SearchResult> GetSearchResults(string url, string keyword);
    }
}