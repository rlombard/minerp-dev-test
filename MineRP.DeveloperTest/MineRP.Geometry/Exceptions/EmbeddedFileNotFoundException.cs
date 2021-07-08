using System;
using System.Runtime.Serialization;

namespace MineRP.Geometry.Exceptions
{
    public class EmbeddedFileNotFoundException : Exception
    {
        public EmbeddedFileNotFoundException() : base("Embedded File Not Found.")
        {
        }

        public EmbeddedFileNotFoundException(Exception innerException) : base("Embedded File Not Found.", innerException)
        {
        }
        
        protected EmbeddedFileNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
