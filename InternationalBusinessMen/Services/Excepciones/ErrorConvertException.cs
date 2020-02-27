using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternationalBusinessMen.Services.Excepciones
{
    public class ErrorConvertException : Exception
    {
        public ErrorConvertException() : base() { }
        public ErrorConvertException(string message) : base(message) { }
        public ErrorConvertException(string message, System.Exception inner) : base(message, inner) { }

        protected ErrorConvertException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}