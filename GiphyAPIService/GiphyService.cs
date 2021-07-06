using GiphyAPIContract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GiphyAPIService
{
    public class GiphyService : IGiphyService
	{
		public List<Gif> GetAllGiphy()
		{
            List<Gif> gifs = new List<Gif>();
            string url = $"api.giphy.com/v1/gifs/trending?api_key=28O0TYbdJbuka6K6WIZVvftVrZqzAtyT&limit=20";
            gifs=GetData(url);
            return gifs;
        }

        public List<Gif> SearchGigphy(string search)
		{
           List<Gif> gifs = new List<Gif>();
            string url = $"api.giphy.com/v1/gifs/search?q={search}&api_key=28O0TYbdJbuka6K6WIZVvftVrZqzAtyT&limit=20";
            gifs = GetData(url);
            return gifs;
        }

        private List<Gif> GetData(string url)
        {
            Root root = null;
            List<Gif> gifs = new List<Gif>();
            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json;charset=utf-8";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();

                    root = (Root)Newtonsoft.Json.JsonConvert.DeserializeObject(responseText, typeof(Root));
                    gifs = root.data;


                }

            }
            catch (Exception webex)
            {

                Console.WriteLine(webex.Message + webex.StackTrace);
            }
            finally { }
            return gifs;
        }
	}
}
