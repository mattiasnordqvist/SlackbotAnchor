using Newtonsoft.Json;

using WebAnchor;
using WebAnchor.RequestFactory.Serialization;

namespace SlackbotAnchor.IncomingWebhook.Internal
{
    public class IncomingWebhookSettings : DefaultApiSettings
    {
        public IncomingWebhookSettings()
        {
            Request.ContentSerializer = new JsonContentSerializer(new JsonSerializer { ContractResolver = new CamelToSnakeContractResolver() });
        }
    }
}