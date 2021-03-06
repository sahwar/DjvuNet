﻿using System;

namespace DjvuNet.Errors
{
    public class DjvuArgumentException : ArgumentException
    {
        public DjvuArgumentException() : base()
        {
        }

        public DjvuArgumentException(string message) : base(message)
        {
        }

        public DjvuArgumentException(string message, Exception innerException)
            : base (message, innerException)
        {
        }

        public DjvuArgumentException(string message, string paramName)
            : base (message, paramName)
        {
        }

        public DjvuArgumentException(string message, string paramName, Exception innerException)
            : base (message, paramName, innerException)
        {
        }

#if !NETSTANDARD2_0
        public DjvuArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base (info, context)
        {
        }
#endif

    }
}
