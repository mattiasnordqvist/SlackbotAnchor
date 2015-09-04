using System.Net.Http;
using System.Threading.Tasks;

using WebAnchor.RequestFactory;
using WebAnchor.RequestFactory.HttpAttributes;
using WebAnchor.RequestFactory.Transformation.Transformers;

namespace SlackbotAnchor
{
    [BaseLocation("/services/hooks/slackbot")]
    public interface ISlackbotApi
    {
        [Post("")]
        Task<HttpResponseMessage> Post(string token, string channel, [Content]string text);
    }
}
