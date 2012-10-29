using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Dimebrain.TweetSharp.Fluent;
using Dimebrain.TweetSharp.Model;
using Dimebrain.TweetSharp.Extensions;
using Retweet.Web.Services;

namespace Retweet.Web.Controllers
{
    public class AccountController : Controller
    {
        private const string OAUTH_CONSUMER_KEY = "hRZSiI4sl7XwoBAOQBQ54g";
        private const string OAUTH_CONSUMER_SECRET = "DNC96Mcr6lSyaqojohl42VLhKu3WefmSqjfEnM8";

        public ActionResult SignIn()
        {
            var twitter = FluentTwitter.CreateRequest()
                .Authentication.GetRequestToken(OAUTH_CONSUMER_KEY, OAUTH_CONSUMER_SECRET);

            var response = twitter.Request();
            var token = response.AsToken();

            CookieService.OAuthRequestToken = token.Token;
            CookieService.OAuthRequestTokenSecret = token.TokenSecret;
            CookieService.SetExpirationDate(DateTime.Now.AddDays(1));

            string authUrl = FluentTwitter.CreateRequest()
                .Authentication.GetAuthorizationUrl(token.Token, "http://localhost:8080:38315/callback");

            
            return Redirect(authUrl);
        }

        public ActionResult SignOut()
        {
            CookieService.SetExpirationDate(DateTime.Now);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Callback()
        {
            if (CookieService.HasRequstTokenPair)
            {
                var twitter = FluentTwitter.CreateRequest()
                    .Authentication.GetAccessToken(OAUTH_CONSUMER_KEY,
                                                   OAUTH_CONSUMER_SECRET,
                                                   CookieService.OAuthRequestToken);

                var response = twitter.Request();
                var token = response.AsToken();

                CookieService.OAuthAccessToken = token.Token;
                CookieService.OAuthAccessTokenSecret = token.TokenSecret;
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
