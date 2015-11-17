using WebAnchor;

namespace SlackbotAnchor
{
    public class SlackBotSettings : ApiSettings
    {
        public SlackBotSettings()
        {
            ContentSerializer = new RawContentSerializer();
        }
    }
}