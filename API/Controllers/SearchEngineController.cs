using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using Application.Services.Core;
using Domain;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchEngineController
    {
        private readonly ICoreService _core;
        public SearchEngineController(ICoreService core)
        {
            _core = core;

        }
        [HttpGet]
        public  ActionResult<List<SearchResult>> GetOccurences(string url, string keyword)
        {
            return  _core.GetSearchResults(url, keyword);
        }
    }
}