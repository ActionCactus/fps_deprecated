using System;

namespace ActionCactus.Framework.Exceptions
{
    /// <summary>
    /// A base exception for project-generated errors.
    /// </summary>
    public abstract class ActionCactusException : Exception
    {
        public ActionCactusException() { }

        public ActionCactusException(string message) : base(message) { }

        public ActionCactusException(string message, Exception inner) : base(message, inner) { }
    }
}