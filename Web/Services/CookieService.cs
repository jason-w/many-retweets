using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retweet.Web.Services
{
    public static class CookieService
    {
        private const string OAUTH_SESSION_REQUEST_TOKEN = "oauth_request_token";
        private const string OAUTH_SESSION_REQUEST_TOKEN_SECRET = "oauth_request_token_secret";
        private const string OAUTH_SESSION_ACCESS_TOKEN = "oauth_access_token";
        private const string OAUTH_SESSION_ACCESS_TOKEN_SECRET = "oauth_access_token_secret";
        private const string OAUTH_COOKIE_NAME = "OAUTH";

        public static string OAuthRequestToken
        {
            get
            {
                if (HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME] == null)
                    return String.Empty;
                else
                    return HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_REQUEST_TOKEN] ?? String.Empty;
            }
            set
            {
                HttpContext.Current.Response.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_REQUEST_TOKEN] = value;
            }
        }

        public static string OAuthRequestTokenSecret
        {
            get
            {
                if (HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME] == null)
                    return String.Empty;
                else
                    return HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_REQUEST_TOKEN_SECRET] ?? String.Empty;
            }
            set
            {
                HttpContext.Current.Response.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_REQUEST_TOKEN_SECRET] = value;
            }
        }

        public static string OAuthAccessToken
        {
            get
            {
                if (HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME] == null)
                    return String.Empty;
                else
                    return HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_ACCESS_TOKEN] ?? String.Empty;
            }
            set
            {
                HttpContext.Current.Response.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_ACCESS_TOKEN] = value;
            }
        }

        public static string OAuthAccessTokenSecret
        {
            get
            {
                if (HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME] == null)
                    return String.Empty;
                else
                    return HttpContext.Current.Request.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_ACCESS_TOKEN_SECRET] ?? String.Empty;
            }
            set
            {
                HttpContext.Current.Response.Cookies[OAUTH_COOKIE_NAME][OAUTH_SESSION_ACCESS_TOKEN_SECRET] = value;
            }
        }

        public static void SetExpirationDate(DateTime expiration)
        {
            HttpContext.Current.Response.Cookies[OAUTH_COOKIE_NAME].Expires = expiration;
        }

        public static bool HasAccessTokenPair
        {
            get { return !String.IsNullOrEmpty(OAuthAccessToken) && !String.IsNullOrEmpty(OAuthAccessToken); }
        }

        public static bool HasRequstTokenPair
        {
            get { return !String.IsNullOrEmpty(OAuthRequestToken) && !String.IsNullOrEmpty(OAuthRequestTokenSecret); }
        }
    }
}
