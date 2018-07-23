using System;

namespace ActionCactus.Framework.Exceptions
{
    /// <summary>
    /// Used to indicate 'boneheaded' configuration errors.
    /// </summary>
    public class InternalConfigurationException : ActionCactusException
    {
        public InternalConfigurationException() { }

        public InternalConfigurationException(string message) : base(message) { }

        public InternalConfigurationException(string message, Exception inner) : base(message, inner) { }
    }
}