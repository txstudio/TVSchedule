using CsQuery;
using ScheduleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleParser
{
    /// <summary>
    /// 取得節目表分類清單
    /// </summary>
    public sealed class ChannelCategoryParser
    {
        const string selector_list = "#moments_channel>li";
        const string attribute_name = "data-id";
        

        public IEnumerable<ChannelCategory> Parse(string html)
        {
            CQ _query = new CQ(html);

            List<ChannelCategory> _cateories;

            var _lists = _query.Find(selector_list);

            _cateories = new List<ChannelCategory>();

            _lists.Each((list) => {
                this.SetCategoryList(_cateories, list);
            });

            return _cateories.ToArray();
        }

        private void SetCategoryList(IList<ChannelCategory> categories
                                    , IDomObject dom)
        {
            var _category = this.GetCategory(dom);

            if (_category == null)
                return;

            categories.Add(_category);
        }

        private ChannelCategory GetCategory(IDomObject dom)
        {
            int _id;
            string _attribute;
            string _name;

            if (dom == null)
                return null;

            _attribute = dom.GetAttribute(attribute_name);

            _id = Convert.ToInt32(_attribute);
            _name = dom.InnerText;

            return new ChannelCategory() {
                Id = _id,
                Name = _name
            };
        }

    }
}
