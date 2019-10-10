using System;
using System.Net.Http;
using System.Threading.Tasks;

using WebAnchor.Attributes.Content;
using WebAnchor.Attributes.URL;

namespace SlackbotAnchor
{
    [BaseLocation("/services/hooks/slackbot")]
    public interface ISlackbotApi : IDisposable
    {
        [Post("")]
        Task<HttpResponseMessage> Post(string token, string channel, [Content]string text);
    }
}
