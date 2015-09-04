using System.Net.Http;

using WebAnchor.RequestFactory;

namespace SlackbotAnchor
{
    public class RawContentSerializer : IContentSerializer
    {
        public HttpContent Serialize(Parameter content)
        {
            return new StringContent(content.Value.ToString());
        }
    }
}