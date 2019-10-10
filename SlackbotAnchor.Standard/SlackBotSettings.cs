using WebAnchor;

namespace SlackbotAnchor
{
    public class SlackBotSettings : DefaultApiSettings
    {
        public SlackBotSettings()
        {
            Request.ContentSerializer = new RawContentSerializer();
        }
    }
}