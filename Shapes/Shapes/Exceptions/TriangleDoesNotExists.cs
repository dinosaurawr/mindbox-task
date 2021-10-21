using System;

namespace Shapes.Exceptions
{
    public class TriangleDoesNotExistException : Exception
    {
        public TriangleDoesNotExistException()
        {
        }

        public TriangleDoesNotExistException(string message)
            : base(message)
        {
        }

        public TriangleDoesNotExistException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
