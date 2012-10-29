using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retweet.Web.ViewData
{
    public class StatusViewData
    {
        public string AvatarHtml { get; set; }
        public string MessageHtml { get; set; }
        public string RelativeTimeHtml { get; set; }
        public string SourceHtml { get; set; }
        public string ReplyLinkHtml { get; set; }
        public string ViewTweetLinkHtml { get; set; }
    }
}
