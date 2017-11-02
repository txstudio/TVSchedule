using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using ScheduleData;
using FluentAssertions;
using FluentAssertions.Equivalency;

namespace ScheduleParser.XUnitTest
{
    public sealed class ChannelByCategoryParserTest
    {
        [Fact]
        public void ParseHtmlToChannel()
        {
            var _content = StaticPageSource.TVCategoryPage();

            ChannelByCategoryParser _parser;

            _parser = new ChannelByCategoryParser();

            var _items = _parser.Parse(_content);
            var _actual = _items;

            var _expected = new List<Channel>();
            _expected.Add(new Channel() { CategoryId = 2, Id = 11, Name = "衛視電影台" });
            _expected.Add(new Channel() { CategoryId = 2, Id = 10, Name = "緯來電影台" });
            _expected.Add(new Channel() { CategoryId = 2, Id = 9, Name = "東森電影台" });
            _expected.Add(new Channel() { CategoryId = 2, Id = 8, Name = "LS TIME電影台" });
            
            Assert.Equal(_expected, _actual);
        }

    }
}
