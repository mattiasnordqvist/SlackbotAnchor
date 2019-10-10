using System.Net.Http;

using WebAnchor.RequestFactory;
using WebAnchor.RequestFactory.Serialization;

namespace SlackbotAnchor
{
    public class RawContentSerializer : IContentSerializer
    {
        public HttpContent Serialize(object value, Parameter content)
        {
            return new StringContent(value.ToString());
        }
    }
}