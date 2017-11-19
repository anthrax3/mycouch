﻿using System.Net.Http;
using EnsureThat;
using MyCouch.Net;
using MyCouch.Requests;

namespace MyCouch.HttpRequestFactories
{
    public class HeadDatabaseHttpRequestFactory
    {
        public virtual HttpRequest Create(HeadDatabaseRequest request)
        {
            Ensure.Any.IsNotNull(request, nameof(request));

            return new HttpRequest(HttpMethod.Head, GenerateRelativeUrl(request))
                .SetRequestTypeHeader(request.GetType());
        }

        protected virtual string GenerateRelativeUrl(HeadDatabaseRequest request)
        {
            return "/";
        }
    }
}