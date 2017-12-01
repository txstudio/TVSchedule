using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleData
{
    /// <summary>電視頻道</summary>
    public sealed class Channel
    {
        private readonly string[] replace_links = new string[] {
                                                    "https://tw.movies.yahoo.com/tv_channels.html?channel="
                                                    ,"https://movies.yahoo.com.tw/tv_channels.html?channel="
                                                };

        private int _id;
        private string _name;

        /// <summary>識別碼</summary>
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>名稱</summary>
        public string Name
        {
            get
            {
                return this._name.Trim();
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>頻道類別識別碼</summary>
        public int CategoryId { get; set; }


        public void SetIdByUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url) == true)
            {
                this._id = 0;
                return;
            }

            foreach (var replace_link in replace_links)
                url = url.Replace(replace_link, string.Empty);

            var _id = url;

            this._id = Convert.ToInt32(_id);
        }



        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;


            var _channel = obj as Channel;
            var _comparison = StringComparison.OrdinalIgnoreCase;


            if (int.Equals(this.Id, _channel.Id) == false)
                return false;

            if (int.Equals(this.CategoryId, _channel.CategoryId) == false)
                return false;

            if (string.Equals(this.Name, _channel.Name, _comparison) == false)
                return false;


            return true;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode()
                    ^ this.CategoryId.GetHashCode()
                    ^ this.Name.GetHashCode();
        }

    }
}
