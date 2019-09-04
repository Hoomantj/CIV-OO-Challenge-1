using System;
namespace Class_Library
{
    public class InvalidLengthException : Exception
    {
        public InvalidLengthException(string message) : base(message)
        {

        }
    }
}
