using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleData
{
    /// <summary>
    /// 日期清單
    /// </summary>
    public sealed class CategoryDate
    {
        private string _dateString;

        public string Date
        {
            get
            {
                return this._dateString;
            }
            set
            {
                this._dateString = value;
            }
        }

        public Nullable<DateTime> DateObject
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this._dateString) == true)
                    return null;

                return Convert.ToDateTime(this._dateString);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var _item = obj as CategoryDate;

            if (string.Equals(this.Date
                            , _item.Date
                            , StringComparison.OrdinalIgnoreCase) == false)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return this.Date.GetHashCode();
        }

    }
}
