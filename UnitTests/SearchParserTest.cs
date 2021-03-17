using System;
using Xunit;
using Application.Services.SearchParser;

namespace UnitTests
{
    public class SearchParserTest
    {
        [Fact]
        public void GetResults_GivenOneDiv()
        {
            var div = "<div class=\"r\"><a href=\"https://www.infotrack.com.au/solutions/searches-certificates/\" ping=\"/url?sa=t&amp;source=web&amp;rct=j&amp;url=https://www.infotrack.com.au/solutions/searches-certificates/&amp;ved=2ahUKEwiamrzcj4jrAhXRZSsKHZQkC0QQFjAAegQIBBAB\"><br><h3 class=\"LC20lb DKV0Md\">Searches &amp; Certificates | InfoTrack</h3><div class=\"TbwUpd NJjxre\"><cite class=\"iUh30 bc tjvcx\">www.infotrack.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite></div></a><div class=\"B6fmyf\"><div class=\"TbwUpd\"><cite class=\"iUh30 bc tjvcx\">www.infotrack.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite>";
            string[] divs = {div};
            var parser = new SearchParser();
            var result = parser.GetResults(divs, "www.infotrack.com.au");
            Assert.Equal("1", result);
        }
        [Fact]
        public void GetResults_GivenThreeDivs()
        {
            var div1 = "<div class=\"r\"><a href=\"https://www.infotrack.com.au/solutions/searches-certificates/\" ping=\"/url?sa=t&amp;source=web&amp;rct=j&amp;url=https://www.infotrack.com.au/solutions/searches-certificates/&amp;ved=2ahUKEwiamrzcj4jrAhXRZSsKHZQkC0QQFjAAegQIBBAB\"><br><h3 class=\"LC20lb DKV0Md\">Searches &amp; Certificates | InfoTrack</h3><div class=\"TbwUpd NJjxre\"><cite class=\"iUh30 bc tjvcx\">www.infotrack.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite></div></a><div class=\"B6fmyf\"><div class=\"TbwUpd\"><cite class=\"iUh30 bc tjvcx\">www.infotrack.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite>";
            var div2 = "<div class=\"r\"><a href=\"https://www.infotrackgo.com.au/solutions/searches-certificates/\" ping=\"/url?sa=t&amp;source=web&amp;rct=j&amp;url=https://www.infotrackgo.com.au/solutions/searches-certificates/&amp;ved=2ahUKEwiamrzcj4jrAhXRZSsKHZQkC0QQFjAAegQIBBAB\"><br><h3 class=\"LC20lb DKV0Md\">Searches &amp; Certificates | InfoTrack</h3><div class=\"TbwUpd NJjxre\"><cite class=\"iUh30 bc tjvcx\">www.infotrackgo.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite></div></a><div class=\"B6fmyf\"><div class=\"TbwUpd\"><cite class=\"iUh30 bc tjvcx\">www.infotrackgo.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite>";
            var div3 = "<div class=\"r\"><a href=\"https://www.infotrack.com.au/solutions/searches-certificates/\" ping=\"/url?sa=t&amp;source=web&amp;rct=j&amp;url=https://www.infotrack.com.au/solutions/searches-certificates/&amp;ved=2ahUKEwiamrzcj4jrAhXRZSsKHZQkC0QQFjAAegQIBBAB\"><br><h3 class=\"LC20lb DKV0Md\">Searches &amp; Certificates | InfoTrack</h3><div class=\"TbwUpd NJjxre\"><cite class=\"iUh30 bc tjvcx\">www.infotrack.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite></div></a><div class=\"B6fmyf\"><div class=\"TbwUpd\"><cite class=\"iUh30 bc tjvcx\">www.infotrack.com.au<span class=\"eipWBe\"> › Innovative Solutions</span></cite>";
            
            string[] divs = {div1, div2, div3};
            var parser = new SearchParser();
            var result = parser.GetResults(divs, "www.infotrack.com.au");
            Assert.Equal("1, 3", result);
        }
    }
}
