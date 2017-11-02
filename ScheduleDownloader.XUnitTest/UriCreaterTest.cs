using System;
using Xunit;
using ScheduleDownloader;

namespace ScheduleDownloader.XUnitTest
{
    public sealed class UriCreaterTest
    {
        [Fact]
        public void GetIndexURLAsNormal()
        {
            var _actual = UriCreater.GetIndexUrl(1);
            var _expected = "https://tw.movies.yahoo.com/tv_index.html?category_id=1";

            Assert.Equal<string>(_expected, _actual);
        }

        [Fact]
        public void GetIndexURLAsNull()
        {
            var _actual = UriCreater.GetIndexUrl(null);
            var _expected = "https://tw.movies.yahoo.com/tv_index.html";

            Assert.Equal<string>(_expected, _actual);
        }

        [Fact]
        public void GetChannelURLAsNormal()
        {
            var _date = new DateTime(1988, 1, 18);
            var _channelId = 1;

            var _acutal = UriCreater.GetChannelUrl(_date, _channelId);
            var _expected = "https://tw.movies.yahoo.com/tv_channels.html?mtime_date=1988-01-18&channel=1";

            Assert.Equal<string>(_expected, _acutal);
        }

        [Fact]
        public void GetChannelURLAsNullDate()
        {
            var _channelId = 1;
            var _new = DateTime.Now;

            var _acutal = UriCreater.GetChannelUrl(null, _channelId);
            var _expected = string.Format("https://tw.movies.yahoo.com/tv_channels.html?mtime_date={0:yyyy-MM-dd}&channel=1", _new);

            Assert.Equal<string>(_expected, _acutal);
        }

        [Fact]
        public void GetChannelURLAsNullChannelId()
        {
            var _date = new DateTime(1988, 1, 18);
            var _new = DateTime.Now;

            ArgumentNullException ex =
                Assert.Throws<ArgumentNullException>(
                    () => UriCreater.GetChannelUrl(_date, null)
                    );
        }

        [Fact]
        public void GetChannelURLAllNull()
        {
            ArgumentNullException ex =
                Assert.Throws<ArgumentNullException>(
                    () => UriCreater.GetChannelUrl(null, null)
                    );
        }
    }
}
