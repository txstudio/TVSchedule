using CsQuery;
using ScheduleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleParser
{
    public sealed class ScheduleParser
    {
        const string selector_list = ".period_box li";
        const string selector_time = "div:eq(0)";
        const string selector_name = "div:eq(1)";

        public IEnumerable<Schedule> Parse(string html)
        {
            CQ _query = new CQ(html);

            List<Schedule> _schedules;

            _schedules = new List<Schedule>();

            var _matches = _query.Find(selector_list);
            var _index = 0;

            _matches.Each((item) => {
                CQ _schedule = new CQ(item.OuterHTML);
                var _time = _schedule.Find(selector_time).FirstElement().InnerText;
                var _name = _schedule.Find(selector_name).FirstElement().InnerText;
                
                _schedules.Add(new Schedule() {
                    Index = _index,
                    Time = _time,
                    Name = _name
                });

                _index = _index + 1;
            });

            return _schedules.ToArray();
        }
        
    }
}
