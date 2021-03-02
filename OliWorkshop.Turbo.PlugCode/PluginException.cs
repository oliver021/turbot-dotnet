﻿using System;
using System.Runtime.Serialization;

namespace OliWorkshop.Turbo.PlugCode
{
    [Serializable]
    internal class PluginException : Exception
    {
        public PluginException()
        {
        }

        public PluginException(string message) : base(message)
        {
        }

        public PluginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PluginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}