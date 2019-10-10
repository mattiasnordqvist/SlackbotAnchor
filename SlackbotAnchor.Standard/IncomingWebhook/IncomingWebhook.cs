using System;
using System.Net.Http;
using System.Threading.Tasks;

using SlackbotAnchor.IncomingWebhook.Internal;

using WebAnchor;

namespace SlackbotAnchor.IncomingWebhook
{
    public class IncomingWebhook : IDisposable
    {
        private readonly IIncomingWebookApi _api;

        public IncomingWebhook(string webhookUrl)
        {
            _api = Api.For<IIncomingWebookApi>(webhookUrl, new IncomingWebhookSettings());
        }

        public Task<HttpResponseMessage> Post(Message message)
        {
            return _api.Send(message);
        }

        public void Dispose()
        {
            _api.Dispose();
        }
    }
}