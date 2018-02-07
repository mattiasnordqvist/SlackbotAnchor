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
        protected void TestTheRequest<T>(Action<T> apiCall, Action<HttpRequestMessage> assertHttpRequestMessage, DefaultApiSettings settings = null) where T : class
        {
            var api = new ProxyGenerator().CreateInterfaceProxyWithoutTarget<T>(new InvocationTester(assertHttpRequestMessage, settings));
            apiCall(api);
        }
    }
}