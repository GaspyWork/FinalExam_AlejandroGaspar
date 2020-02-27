using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternationalBusinessMen.Services.Excepciones
{
    public class NullException : Exception
    {
        public NullException() : base() { }
        public NullException(string message) : base(message) { }
        public NullException(string message, System.Exception inner) : base(message, inner) { }

        protected NullException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    }
}