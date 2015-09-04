using WebAnchor;
using WebAnchor.RequestFactory;

namespace SlackbotAnchor
{
    public class SlackBotSettings : ApiSettings
    {
        public override IContentSerializer CreateContentSerializer()
        {
            return new RawContentSerializer();
        }
    }
}