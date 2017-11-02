using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ScheduleDownloader
{
    public sealed class UriCreater
    {
        private static readonly string baseAddress = "https://tw.movies.yahoo.com/";

        private static readonly string indexPage = "tv_index.html";
        private static readonly string channelPage = "tv_channels.html";


        public static string GetIndexUrl(Nullable<int> id)
        {
            var _mainUrl = Path.Combine(baseAddress, indexPage);

            if (id.HasValue == false)
                return _mainUrl;

            return String.Format("{0}?category_id={1}", _mainUrl, id);
        }

        public static string GetChannelUrl(Nullable<DateTime> date, Nullable<int> channelId)
        {
            var _mainUrl = Path.Combine(baseAddress, channelPage);

            if (date.HasValue == false)
                date = DateTime.Now.Date;

            if (channelId.HasValue == false)
                throw new ArgumentNullException("channelId");

            return string.Format("{0}?mtime_date={1:yyyy-MM-dd}&channel={2}"
                                , _mainUrl
                                , date.Value
                                , channelId.Value);
        }
    }
}
