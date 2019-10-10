using System;
using System.Net.Http;

using WebAnchor;

namespace SlackbotAnchor
{
    public class Slackbot : IDisposable
    {
        private readonly string _token;
        private readonly ISlackbotApi _api;

        public Slackbot(string team, string token)
        {
            _token = token;
            
            _api = Api.For<ISlackbotApi>($"https://{team}.slack.com", new SlackBotSettings());
        }

        public virtual HttpResponseMessage Post(string channel, string text)
        {
            if (!channel.StartsWith("#"))
            {
                channel = "#" + channel;
            }

            var result = _api.Post(_token, channel, text).Result;
            return result;
        }

        public void Dispose()
        {
            _api.Dispose();
        }
    }
}