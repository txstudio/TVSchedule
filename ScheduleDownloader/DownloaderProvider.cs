using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ScheduleDownloader
{
    public abstract class DownloaderProvider
    {
        protected readonly string baseAddress = "https://tw.movies.yahoo.com/";

        protected HttpClient _client;

        public DownloaderProvider()
        {
            this._client = new HttpClient();
            this._client.BaseAddress = new Uri(baseAddress);
        }
        
    }
}
