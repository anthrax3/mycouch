﻿using System;

namespace MyCouch.Responses
{
#if !NETFX_CORE
    [Serializable]
#endif
    public class DatabaseResponse : Response
    {
        public string Content { get; set; }
    }
}