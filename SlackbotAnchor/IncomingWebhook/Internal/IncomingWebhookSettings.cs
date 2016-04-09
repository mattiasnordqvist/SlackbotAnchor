using Newtonsoft.Json;

using WebAnchor;
using WebAnchor.RequestFactory;

namespace SlackbotAnchor.IncomingWebhook.Internal
{
    public class IncomingWebhookSettings : ApiSettings
    {
        public IncomingWebhookSettings()
        {
            ContentSerializer = new ContentSerializer(new JsonSerializer() {ContractResolver = new CamelToSnakeContractResolver() });
        }
    }
}