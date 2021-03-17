namespace Application.SearchEngines
{
    public interface IBingEngine
    {
        public string GetOccurences(string url, string keyword);

    }
}