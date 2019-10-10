using System;
using System.Net.Http;
using System.Threading.Tasks;

using WebAnchor.Attributes.Content;
using WebAnchor.Attributes.URL;

namespace SlackbotAnchor.IncomingWebhook.Internal
{
    [BaseLocation("")]
    public interface IIncomingWebookApi : IDisposable
    {
        [Post("")]
        Task<HttpResponseMessage> Send([Content]Message message);
    }
}