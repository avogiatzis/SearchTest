namespace Application.SearchEngines
{
    public interface IGoogleEngine
    {
        public string GetOccurences(string url, string keyword);
    }
}