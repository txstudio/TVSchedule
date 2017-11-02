using CsQuery;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleParser
{
    public abstract class HtmlParserProvider
    {
        protected CQ _query;

        public HtmlParserProvider()
        {
            this._query = new CQ();
        }
    }
}
