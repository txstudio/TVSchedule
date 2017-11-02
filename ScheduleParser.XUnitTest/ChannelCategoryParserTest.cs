using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Xunit;
using ScheduleData;
using System.Text;

namespace ScheduleParser.XUnitTest
{
    public class ChannelCategoryParserTest
    {

        //將網頁內容讀取成 ChannelCategory 清單物件
        [Fact]
        public void ParseHtmlToCategory()
        {
            var _content = StaticPageSource.TVHomePage();

            ChannelCategoryParser _parser;
            List<ChannelCategory> _expected;

            _parser = new ChannelCategoryParser();

            _expected = new List<ChannelCategory>();
            _expected.Add(new ChannelCategory() { Id = 1, Name = "西片" });
            _expected.Add(new ChannelCategory() { Id = 2, Name = "國片" });
            _expected.Add(new ChannelCategory() { Id = 3, Name = "戲劇" });
            _expected.Add(new ChannelCategory() { Id = 4, Name = "體育" });
            _expected.Add(new ChannelCategory() { Id = 5, Name = "綜合" });
            _expected.Add(new ChannelCategory() { Id = 6, Name = "知性" });
            _expected.Add(new ChannelCategory() { Id = 7, Name = "日本" });
            _expected.Add(new ChannelCategory() { Id = 8, Name = "音樂" });
            _expected.Add(new ChannelCategory() { Id = 9, Name = "卡通" });
            _expected.Add(new ChannelCategory() { Id = 10, Name = "新聞" });
            _expected.Add(new ChannelCategory() { Id = 11, Name = "財經" });
            _expected.Add(new ChannelCategory() { Id = 12, Name = "宗教" });

            var _items = _parser.Parse(_content);
            var _actual = _items;
            
            Assert.Equal<ChannelCategory>(_expected, _actual);
        }

        //輸入空白網頁內容
        [Fact]
        public void ParserEmptyHtmlToCategory()
        {
            ChannelCategoryParser _parser;

            _parser = new ChannelCategoryParser();

            var _items = _parser.Parse(string.Empty);

            Assert.NotNull(_items);
        }

    }
}
