using System;
using System.Runtime.Serialization;

namespace TasksManager.DAL
{
    [Serializable]
    internal class ReadValueFromExcelException : Exception
    {
        public ReadValueFromExcelException()
        {
        }

        public ReadValueFromExcelException(string message) : base(message)
        {
        }

        public ReadValueFromExcelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReadValueFromExcelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}