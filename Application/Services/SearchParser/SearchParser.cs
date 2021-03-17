using System.Collections.Generic;

namespace Application.Services.SearchParser
{
    public class SearchParser : ISearchParser
    {
        public string GetResults(string[] divs, string url){
            var count= 0;
            string results = "0";
            var index=1;

            foreach(var div in divs){

                if (div.Contains(url))  {
                    
                    count++;
                    if(count ==1){
                        results=$"{index}";
                    }else{
                        results+=$", {index}";
                    }
                }
                index++;

            }
            return (results) ;
        }
    }
}