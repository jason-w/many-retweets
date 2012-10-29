using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dimebrain.TweetSharp.Fluent;
using Dimebrain.TweetSharp.Model;
using Dimebrain.TweetSharp.Extensions;
using Retweet.Web.ViewData;

namespace Retweet.Web.Services
{
    public static class TwitterService
    {
        private static const string OAUTH_CONSUMER_KEY = "hRZSiI4sl7XwoBAOQBQ54g";
        private static const string OAUTH_CONSUMER_SECRET = "DNC96Mcr6lSyaqojohl42VLhKu3WefmSqjfEnM8";

        public static List<StatusViewData> GetFriendTimeline(string accessToken, string accessTokenSecret)
        {
            List<StatusViewData> statuses = new List<StatusViewData>();

            var twitter = FluentTwitter.CreateRequest()
                    .AuthenticateWith(OAUTH_CONSUMER_KEY,OAUTH_CONSUMER_SECRET,accessToken,accessTokenSecret)                    
                    .Statuses()
                    .OnFriendsTimeline()
                    .Take(20)
                    .AsJson();

            try
            {
                var request = twitter.Request();

                var rawStatuses = request.AsStatuses();                

                if (statuses != null)
                {
                    foreach (TwitterStatus status in rawStatuses)
                    {

                    }
                }
            }
            catch
            {
                return statuses;
            }
        }
    }
}
