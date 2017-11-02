using CsQuery;
using ScheduleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleParser
{
    /// <summary>
    /// 取得提供可顯示節目表的日期
    /// </summary>
    public class CategoryDateParser
    {
        const string selector_select = "select[name='category_date']>option";

        public IEnumerable<CategoryDate> Paser(string html)
        {
            CQ _query = new CQ(html);

            List<CategoryDate> _categoryDates;

            var _dates = _query.Find(selector_select);

            _categoryDates = new List<CategoryDate>();
            
            _dates.Each((date) =>
            {
                _categoryDates.Add(new CategoryDate() {
                    Date = date.InnerText.Trim()
                });
            });

            return _categoryDates.ToArray();
        }
    }
}
