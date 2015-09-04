using System.Net.Http;

using WebAnchor;

namespace SlackbotAnchor
{
    public class Slackbot
    {
        private readonly string _token;
        private readonly ISlackbotApi _api;

        public Slackbot(string team, string token)
        {
            _token = token;
            
            _api = Api.For<ISlackbotApi>(string.Format("https://{0}.slack.com", team), new SlackBotSettings());
        }

        public HttpResponseMessage Post(string channel, string text)
        {
            if (!channel.StartsWith("#"))
            {
                channel = "#" + channel;
            }

            var result = _api.Post(_token, channel, text).Result;
            return result;
        }
    }
}