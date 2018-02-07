using System;
using System.Net.Http;

using Castle.DynamicProxy;

using WebAnchor;
using WebAnchor.RequestFactory;

namespace Tests.Util
{
    public class InvocationTester : IInterceptor
    {
        private readonly Action<HttpRequestMessage> _assert;

        private readonly DefaultApiSettings _settings;

        public InvocationTester(Action<HttpRequestMessage> assert = null, DefaultApiSettings settings = null)
        {
            _settings = settings ?? new DefaultApiSettings();
            _assert = assert ?? (a => { });
        }

        public void Intercept(IInvocation invocation)
        {
            var factory = new HttpRequestFactory(_settings);
            var httpRequest = factory.Create(invocation);
            _assert(httpRequest);
        }
    }
}