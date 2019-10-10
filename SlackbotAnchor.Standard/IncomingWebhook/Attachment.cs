using System.Collections.Generic;

namespace SlackbotAnchor.IncomingWebhook
{
    public class Attachment
    {
        public string Fallback { get; set; }

        public string Color { get; set; }

        public string Pretext { get; set; }

        public string AuthorName { get; set; }
        public string AuthorLink { get; set; }
        public string AuthorIcon { get; set; }

        public string Title { get; set; }
        public string TitleLink { get; set; }

        public string Text { get; set; }

        public List<Field> Fields { get; set; } = new List<Field>();
        
        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }
    }
}