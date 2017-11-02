using ScheduleData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace ScheduleParser.XUnitTest
{
    public class CategoryDateParserTest
    {
        //取得網頁提供選擇的日期清單
        [Fact]
        public void ParserHtmlToDate()
        {
            var _content = StaticPageSource.TVHomePage();

            CategoryDateParser _parser;

            _parser = new CategoryDateParser();

            var _actual = _parser.Paser(_content);
            var _expected = new List<CategoryDate>();

            _expected.Add(new CategoryDate() { Date = "2017-10-15" });
            _expected.Add(new CategoryDate() { Date = "2017-10-16" });
            _expected.Add(new CategoryDate() { Date = "2017-10-17" });
            _expected.Add(new CategoryDate() { Date = "2017-10-18" });
            _expected.Add(new CategoryDate() { Date = "2017-10-19" });
            _expected.Add(new CategoryDate() { Date = "2017-10-20" });

            Assert.Equal<CategoryDate>(_expected, _actual);
        }

    }
}
