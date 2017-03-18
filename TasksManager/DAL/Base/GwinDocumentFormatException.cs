using System;
using System.Runtime.Serialization;

namespace TasksManager.DAL
{
    [Serializable]
    internal class GwinDocumentFormatException : Exception
    {
        public GwinDocumentFormatException()
        {
        }

        public GwinDocumentFormatException(string message) : base(message)
        {
        }

        public GwinDocumentFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GwinDocumentFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}