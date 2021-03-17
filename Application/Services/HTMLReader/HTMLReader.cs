using System.Net;
using System.Text.RegularExpressions;

namespace Application.Services.HTMLReader
{
    public class HTMLReader : IHTMLReader
    {
        public string Read(string engine, string keyword)
        {
            string result = "";
            using (WebClient client = new WebClient())
            {
                for (var i = 1; i <= 9; i++)
                {
                    string htmlCode = client.DownloadString($"https://infotrack-tests.infotrack.com.au/{engine}/Page0{i}.html");
                    var body = htmlCode.Split("<body");
                    result += body[1];
                }
            }

            return result;
        }
    }
}