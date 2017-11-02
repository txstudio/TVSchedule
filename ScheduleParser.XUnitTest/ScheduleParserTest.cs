using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ScheduleData;
using System.Linq;

namespace ScheduleParser.XUnitTest
{
    public sealed class ScheduleParserTest
    {
        [Fact]
        public void ParseHtmlToSchedule()
        {
            var _content = StaticPageSource.TVChannel();
            var _currentDate = "2017-10-24";

            ScheduleParser _parser;

            _parser = new ScheduleParser();

            var _items = _parser.Parse(_content);

            foreach (var item in _items)
                item.Date = _currentDate;

            var _expected = new List<Schedule>();
            _expected.Add(new Schedule() { Index = 0, Date = _currentDate, Name = "老爺車轉生術5-馬自達RX-7", Time = "12:00 AM" });
            _expected.Add(new Schedule() { Index = 1, Date = _currentDate, Name = "納粹祕辛2-致命任務", Time = "1:00 AM" });
            _expected.Add(new Schedule() { Index = 2, Date = _currentDate, Name = "1917俄國大革命	-", Time = "2:00 AM" });
            _expected.Add(new Schedule() { Index = 3, Date = _currentDate, Name = "狡猾黑鮪南北大對決3-因果循環", Time = "3:00 AM" });
            _expected.Add(new Schedule() { Index = 4, Date = _currentDate, Name = "老爺車轉生術5-馬自達RX-7", Time = "4:00 AM" });
            _expected.Add(new Schedule() { Index = 5, Date = _currentDate, Name = "狡猾黑鮪南北大對決3-因果循環", Time = "5:00 AM" });
            _expected.Add(new Schedule() { Index = 6, Date = _currentDate, Name = "超級工廠-菲多利洋芋片", Time = "6:00 AM" });
            _expected.Add(new Schedule() { Index = 7, Date = _currentDate, Name = "超級工廠-意利咖啡", Time = "7:00 AM" });
            _expected.Add(new Schedule() { Index = 8, Date = _currentDate, Name = "極端世界-橋梁", Time = "8:00 AM" });
            _expected.Add(new Schedule() { Index = 9, Date = _currentDate, Name = "無厘頭科學研究所5(2)", Time = "9:00 AM" });
            _expected.Add(new Schedule() { Index = 10, Date = _currentDate, Name = "無厘頭科學研究所5(5)", Time = "9:30 AM" });
            _expected.Add(new Schedule() { Index = 11, Date = _currentDate, Name = "1917俄國大革命	-", Time = "10:00 AM" });
            _expected.Add(new Schedule() { Index = 12, Date = _currentDate, Name = "狡猾黑鮪南北大對決3-因果循環", Time = "11:00 AM" });
            _expected.Add(new Schedule() { Index = 13, Date = _currentDate, Name = "超跑名車大改造2-藍寶堅尼運輸車", Time = "12:00 PM" });
            _expected.Add(new Schedule() { Index = 14, Date = _currentDate, Name = "德州海產王-損害控管", Time = "1:00 PM" });
            _expected.Add(new Schedule() { Index = 15, Date = _currentDate, Name = "德州海產王-工作至上", Time = "2:00 PM" });
            _expected.Add(new Schedule() { Index = 16, Date = _currentDate, Name = "極地生存戰士3-狂暴急流", Time = "3:00 PM" });
            _expected.Add(new Schedule() { Index = 17, Date = _currentDate, Name = "寶石採礦王-哥倫比亞祖母綠", Time = "4:00 PM" });
            _expected.Add(new Schedule() { Index = 18, Date = _currentDate, Name = "部落求生攻略2-凶險峽谷", Time = "5:00 PM" });
            _expected.Add(new Schedule() { Index = 19, Date = _currentDate, Name = "勇廚闖天下-尼泊爾", Time = "6:00 PM" });
            _expected.Add(new Schedule() { Index = 20, Date = _currentDate, Name = "Power知識Cool:極地生存戰士-鋌而走險", Time = "7:00 PM" });
            _expected.Add(new Schedule() { Index = 21, Date = _currentDate, Name = "鬼鎮挖寶賺大錢-開路先鋒", Time = "8:00 PM" });
            _expected.Add(new Schedule() { Index = 22, Date = _currentDate, Name = "創意發明王3-美式足球轉播魔法(首)", Time = "9:00 PM" });
            _expected.Add(new Schedule() { Index = 23, Date = _currentDate, Name = "創意發明王3-寶寶監視裝置(首)", Time = "9:30 PM" });
            _expected.Add(new Schedule() { Index = 24, Date = _currentDate, Name = "極地淘金救援王-摩擦紛爭", Time = "10:00 PM" });
            _expected.Add(new Schedule() { Index = 25, Date = _currentDate, Name = "育空淘金客2-左右為難", Time = "11:00 PM" });
            
            var _actual = _items;

            Assert.Equal<Schedule>(_expected, _actual);
        }
    }
}
