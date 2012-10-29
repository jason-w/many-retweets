using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retweet.Web.ViewData;
using Retweet.Web.Services;

namespace Retweet.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BaseViewData baseViewData = new BaseViewData();
            if (!CookieService.HasAccessTokenPair)
                return View(baseViewData);


            return View(baseViewData);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
