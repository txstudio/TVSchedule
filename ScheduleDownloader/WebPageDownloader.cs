using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ScheduleDownloader
{
    public class WebPageDownloader
    {
        protected HttpClient _client;

        public WebPageDownloader()
        {
            this._client = new HttpClient();
        }

        public string GetIndex(int? categoryId)
        {
            var _url = UriCreater.GetIndexUrl(categoryId);

            var _response = this._client.GetAsync(_url).Result;

            if (_response.IsSuccessStatusCode == true)
            {
                return _response.Content.ReadAsStringAsync().Result;
            }

            return string.Empty;
        }

        public string GetChannel(DateTime? date, int? channelId)
        {
            var _url = UriCreater.GetChannelUrl(date, channelId);

            var _response = this._client.GetAsync(_url).Result;

            if(_response.IsSuccessStatusCode == true)
            {
                return _response.Content.ReadAsStringAsync().Result;
            }

            return string.Empty;
        }
        
    }
}
