using System.Linq;
using System.Text.RegularExpressions;

namespace SlackbotAnchor.IncomingWebhook.Internal
{
    public static class CamelToSnake
    {
        public static string Transform(string camelCased)
        {
            var parts = Regex.Split(camelCased, @"(?<!^)(?=[A-Z])");
            return string.Join("_", parts.Select(x => x.ToLower()).ToList());
        }
    }
}