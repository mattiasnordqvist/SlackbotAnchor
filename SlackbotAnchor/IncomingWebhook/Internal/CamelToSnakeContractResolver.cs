using System.Reflection;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SlackbotAnchor.IncomingWebhook.Internal
{
    public class CamelToSnakeContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            property.PropertyName = CamelToSnake.Transform(property.PropertyName);
            return property;
        }
    }
}