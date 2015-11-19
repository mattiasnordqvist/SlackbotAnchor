using NUnit.Framework;

using SlackbotAnchor;

using Tests.Util;

namespace Tests
{
    [TestFixture]
    public class Tests : WebAnchorTest
    {
        [Test]
        public void TestThatTheRawContentSerializerIsDoingItsJob()
        {
            TestTheRequest<ISlackbotApi>(api => api.Post("atoken", "#channel", "plaintext"), 
                assertHttpRequestMessage: requestMessage => Assert.AreEqual("plaintext", requestMessage.Content.ReadAsStringAsync().Result), 
                settings: new SlackBotSettings());
        }
    }
}