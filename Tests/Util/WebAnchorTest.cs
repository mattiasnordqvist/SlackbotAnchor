using System;
using System.Collections.Generic;
using System.Net.Http;

using Castle.DynamicProxy;

using WebAnchor;
using WebAnchor.RequestFactory;
using WebAnchor.RequestFactory.Transformation;

namespace Tests.Util
{
    public class WebAnchorTest
    {
        protected void TestTheRequest<T>(Action<T> action, Action<HttpRequestMessage> assertHttpRequestMessage, Action<HttpRequestFactory> configure = null, Action<IEnumerable<Parameter>, ParameterTransformContext> assertParametersAndContext = null, ApiSettings settings = null) where T : class
        {
            var api = new ProxyGenerator().CreateInterfaceProxyWithoutTarget<T>(new InvocationTester(assertHttpRequestMessage, configure, assertParametersAndContext, settings));
            action(api);
        }
    }
}