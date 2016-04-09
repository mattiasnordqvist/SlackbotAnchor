using System;
using System.Net.Http;
using System.Threading.Tasks;

using WebAnchor.RequestFactory;
using WebAnchor.RequestFactory.HttpAttributes;
using WebAnchor.RequestFactory.Transformation.Transformers;

namespace SlackbotAnchor.IncomingWebhook.Internal
{
    [BaseLocation("")]
    public interface IIncomingWebookApi : IDisposable
    {
        [Post("")]
        Task<HttpResponseMessage> Send([Content]Message message);
    }
}