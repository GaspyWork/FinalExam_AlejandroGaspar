using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternationalBusinessMen.Services.Excepciones
{
    public class ErrorLogginException : Exception
    {
        public ErrorLogginException() : base() { }
        public ErrorLogginException(string message) : base(message) { }
        public ErrorLogginException(string message, System.Exception inner) : base(message, inner) { }

        protected ErrorLogginException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}