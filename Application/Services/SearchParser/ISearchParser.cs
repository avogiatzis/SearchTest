namespace Application.Services.SearchParser
{
    public interface ISearchParser
    {
        public string GetResults(string[] divs, string url);
    }
}