using NUnit.Framework;

using SlackbotAnchor.IncomingWebhook.Internal;

namespace Tests.IncomingWebhook
{
    [TestFixture]
    public class SnakeCaseTests
    {
        [Test]
        public void TestNoChange()
        {
            Assert.AreEqual("text", CamelToSnake.Transform("Text"));
        }

        [Test]
        public void TestOneChange()
        {
            Assert.AreEqual("image_url", CamelToSnake.Transform("ImageUrl"));
        }

        [Test]
        public void TestTwoChanges()
        {
            Assert.AreEqual("image_url_short", CamelToSnake.Transform("ImageUrlShort"));
        }
    }
}
