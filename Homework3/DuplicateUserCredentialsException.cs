using System;
using System.Runtime.Serialization;

namespace Homework3
{
    [Serializable]
    internal class DuplicateUserCredentialsException : Exception
    {
        public DuplicateUserCredentialsException()
        {
        }

        public DuplicateUserCredentialsException(string message) : base(message)
        {
        }

        public DuplicateUserCredentialsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateUserCredentialsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}