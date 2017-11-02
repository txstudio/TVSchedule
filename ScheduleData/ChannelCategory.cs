using System;

namespace ScheduleData
{
    /// <summary>
    /// 電視頻道分類
    /// </summary>
    public sealed class ChannelCategory
    {
        private string _name;

        /// <summary>識別碼</summary>
        public int Id { get; set; }

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


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var _item = obj as ChannelCategory;

            if (this.Id != _item.Id)
                return false;

            if (string.Equals(this.Name
                            , _item.Name
                            , StringComparison.OrdinalIgnoreCase) == false)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() ^ this.Name.GetHashCode();
        }
    }
}
