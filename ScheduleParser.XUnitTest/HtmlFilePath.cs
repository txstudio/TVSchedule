using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ScheduleParser.XUnitTest
{
    public class HtmlFilePath
    {
        public static string TVIndex
        {
            get
            {
                return "../../../html/tv_index.html";
            }
        }

        public static string TVCategory
        {
            get
            {
                return "../../../html/tv_category.html";
            }
        }

        public static string TVChannel
        {
            get
            {
                return "../../../html/tv_channel.html";
            }
        }
    }

    public class StaticPageSource
    {
        public static string TVHomePage()
        {
            return File.ReadAllText(HtmlFilePath.TVIndex);
        }

        public static string TVCategoryPage()
        {
            return File.ReadAllText(HtmlFilePath.TVCategory);
        }

        public static string TVChannel()
        {
            return File.ReadAllText(HtmlFilePath.TVChannel);
        }
    }

}
