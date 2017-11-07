using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleData
{
    public sealed class Schedule
    {
        public string Date { get; set; }
        public string Time { get; set; }

        public int Index { get; set; }

        /// <summary>節目名稱</summary>
        public string Name { get; set; }

        /// <summary>取得節目播出日期時間</summary>
        public Nullable<DateTime> DateTime
        {
            get
            {
                if(string.IsNullOrWhiteSpace(this.Date) == true
                    || string.IsNullOrWhiteSpace(this.Time) == true)
                {
                    return null;
                }

                var _dateTime = String.Format("{0} {1}", this.Date, this.Time);

                return Convert.ToDateTime(_dateTime);
            }
        }

        /// <summary>取得節目播出時間 (HH:mm)</summary>
        public string Time24
        {
            get
            {
                if (this.DateTime.HasValue == true)
                    return string.Format("{0:HH:mm}", this.DateTime.Value);

                return string.Empty;
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var _schedule = obj as Schedule;
            var _comparison = StringComparison.OrdinalIgnoreCase;

            if (this.Index != _schedule.Index)
                return false;

            if (string.Equals(this.Name, _schedule.Name, _comparison) == false)
                return false;

            if (string.Equals(this.Date, _schedule.Date, _comparison) == false)
                return false;

            if (string.Equals(this.Time, _schedule.Time, _comparison) == false)
                return false;

            if (string.Equals(this.Time24, _schedule.Time24, _comparison) == false)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode()
                ^ this.Name.GetHashCode()
                ^ this.Date.GetHashCode()
                ^ this.Time.GetHashCode()
                ^ this.Time24.GetHashCode();
        }

    }
}
