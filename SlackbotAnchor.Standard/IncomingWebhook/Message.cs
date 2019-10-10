using System.Collections.Generic;

namespace SlackbotAnchor.IncomingWebhook
{
    public class Message
    {
        public string Username { get; set; }
        public string IconEmoji { get; set; }
        public string Text { get; set; }
        public string Channel { get; set; }

        public List<Attachment> Attachments { get; set; } = new List<Attachment>();
    }
}