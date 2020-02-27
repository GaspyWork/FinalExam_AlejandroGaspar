using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternationalBusinessMen.Services.Excepciones
{
    public class ErrorConexionException : Exception
    {
        public ErrorConexionException() : base() { }
        public ErrorConexionException(string message) : base(message) { }
        public ErrorConexionException(string message, System.Exception inner) : base(message, inner) { }

        protected ErrorConexionException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}