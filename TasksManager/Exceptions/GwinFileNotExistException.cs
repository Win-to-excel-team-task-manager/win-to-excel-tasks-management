using System;
using System.Runtime.Serialization;

namespace TasksManager.DAL
{
    [Serializable]
    internal class GwinFileNotExistException : Exception
    {
        public GwinFileNotExistException()
        {
        }

        public GwinFileNotExistException(string message) : base(message)
        {
        }

        public GwinFileNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GwinFileNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}