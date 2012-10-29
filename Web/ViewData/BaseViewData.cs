using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Retweet.Web.Services;

namespace Retweet.Web.ViewData
{
    public class BaseViewData
    {
        public bool IsAuthenticated
        {
            get
            {
                return CookieService.HasAccessTokenPair;
            }
        }
    }
}
