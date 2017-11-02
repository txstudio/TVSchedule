using CsQuery;
using ScheduleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleParser
{
    /// <summary>
    /// 依頻道類別取得頻道清單
    /// </summary>
    public sealed class ChannelByCategoryParser
    {
        const string selector_category = "#content_l li[class=\"select\"]";
        const string attr_name_category = "data-id";

        const string selector_list = ".search_l li";
        const string selector_link = "a";
        const string attr_name_href = "href";

        private int _categoryId;
        

        public IEnumerable<Channel> Parse(string html)
        {
            CQ _query = new CQ(html);

            List<Channel> _channels;

            _channels = new List<Channel>();

            this.SetCategoryId(_query);

            var _lists = _query.Find(selector_list);

            _lists.Each((list) => {
                this.SetChannel(_channels, list);
            });

            return _channels.ToArray();
        }

        private void SetCategoryId(CQ query)
        {
            var _matches = query.Find(selector_category);

            _matches.Each((item) =>{
                var _attr = item.GetAttribute(attr_name_category);
                _categoryId = Convert.ToInt32(_attr);
            });
        }

        private void SetChannel(IList<Channel> channels
                                , IDomObject dom)
        {
            var _channel = this.GetChannel(dom);

            if (_channel == null)
                return;

            channels.Add(_channel);
        }


        private Channel GetChannel(IDomObject dom)
        {
            string _link;
            string _name;

            if (dom == null)
                return null;

            _link = dom.FirstElementChild.GetAttribute(attr_name_href);
            _name = dom.InnerText;

            Channel _channel;

            _channel = new Channel(){ Name = _name, CategoryId = _categoryId };
            _channel.SetIdByUrl(_link);

            return (_channel);
        }
    }
}
