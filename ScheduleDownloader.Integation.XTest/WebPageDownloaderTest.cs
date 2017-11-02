using System;
using Xunit;

namespace ScheduleDownloader.Integation.XTest
{
    public class WebPageDownloaderTest
    {
        [Fact]
        public void GetIndexPage()
        {
            var _categoryId = 1;
            var _source = string.Empty;
            var _downloader = new WebPageDownloader();

            _source = _downloader.GetIndex(_categoryId);

            Assert.NotEqual(string.Empty, _source);
        }

        [Fact]
        public void GetIndexPageWithEmptyCategory()
        {
            var _source = string.Empty;
            var _downloader = new WebPageDownloader();

            _source = _downloader.GetIndex(null);

            Assert.NotEqual(string.Empty, _source);
        }

        [Fact]
        public void GetChannelPage()
        {
            var _date = DateTime.Now.Date;
            var _channelId = 1;

            var _source = string.Empty;
            var _downloader = new WebPageDownloader();

            _source = _downloader.GetChannel(_date, _channelId);

            Assert.NotEqual(string.Empty, _source);
        }
    }
}
