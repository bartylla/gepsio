using System;

namespace JeffFerguson.Gepsio
{
    /// <summary>
    /// The class for all validation errors discovered in the definition arc of a loaded document.
    /// </summary>
    public class DefinitionArcValidationError : ValidationError
    {
        /// <summary>
        /// The definition arc containing the error being reported.
        /// </summary>
        public DefinitionArc Arc { get; private set; }

        /// <summary>
        /// Class constructor. This constructor will store a message and will automatically set the
        /// Exception property to a null value.
        /// </summary>
        /// <param name="arc">
        /// The definition arc containing the error being reported.
        /// </param>
        /// <param name="type">
        /// The type to be stored in the validation error.
        /// </param>
        /// <param name="message">
        /// The message to be stored in the validation error.
        /// </param>
        internal DefinitionArcValidationError(DefinitionArc arc, string type, string message)
            : base(type, message)
        {
            this.Arc = arc;
        }

        /// <summary>
        /// Class constructor. This constructor will store a message and an exception.
        /// </summary>
        /// <param name="arc">
        /// The definition arc containing the error being reported.
        /// </param>
        /// <param name="type">
        /// The type to be stored in the validation error.
        /// </param>
        /// <param name="message">
        /// The message to be stored in the validation error.
        /// </param>
        /// <param name="exception">
        /// The exception to be stored in the validation error.
        /// </param>
        internal DefinitionArcValidationError(DefinitionArc arc, string type, string message, Exception exception)
            : base(type, message, exception)
        {
            this.Arc = arc;
        }
    }
}
