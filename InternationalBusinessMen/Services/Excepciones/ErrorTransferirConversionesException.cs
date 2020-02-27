using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternationalBusinessMen.Services.Excepciones
{
    public class ErrorTransferirConversionesException : Exception
    {
        public ErrorTransferirConversionesException() : base() { }
        public ErrorTransferirConversionesException(string message) : base(message) { }
        public ErrorTransferirConversionesException(string message, System.Exception inner) : base(message, inner) { }

        protected ErrorTransferirConversionesException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}