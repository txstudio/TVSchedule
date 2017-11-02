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

        //�N�������eŪ���� ChannelCategory �M�檫��
        [Fact]
        public void ParseHtmlToCategory()
        {
            var _content = StaticPageSource.TVHomePage();

            ChannelCategoryParser _parser;
            List<ChannelCategory> _expected;

            _parser = new ChannelCategoryParser();

            _expected = new List<ChannelCategory>();
            _expected.Add(new ChannelCategory() { Id = 1, Name = "���" });
            _expected.Add(new ChannelCategory() { Id = 2, Name = "���" });
            _expected.Add(new ChannelCategory() { Id = 3, Name = "���@" });
            _expected.Add(new ChannelCategory() { Id = 4, Name = "��|" });
            _expected.Add(new ChannelCategory() { Id = 5, Name = "��X" });
            _expected.Add(new ChannelCategory() { Id = 6, Name = "����" });
            _expected.Add(new ChannelCategory() { Id = 7, Name = "�饻" });
            _expected.Add(new ChannelCategory() { Id = 8, Name = "����" });
            _expected.Add(new ChannelCategory() { Id = 9, Name = "�d�q" });
            _expected.Add(new ChannelCategory() { Id = 10, Name = "�s�D" });
            _expected.Add(new ChannelCategory() { Id = 11, Name = "�]�g" });
            _expected.Add(new ChannelCategory() { Id = 12, Name = "�v��" });

            var _items = _parser.Parse(_content);
            var _actual = _items;
            
            Assert.Equal<ChannelCategory>(_expected, _actual);
        }

        //��J�ťպ������e
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
