using JeffFerguson.Gepsio.Xsd;
using System;

namespace JeffFerguson.Gepsio
{
    /// <summary>
    /// The class for all validation errors discovered in the element of a loaded schema.
    /// </summary>
    public class ElementValidationError : ValidationError
    {
        /// <summary>
        /// The element containing the error being reported.
        /// </summary>
        public Element Element { get; private set; }

        /// <summary>
        /// Class constructor. This constructor will store a message and will automatically set the
        /// Exception property to a null value.
        /// </summary>
        /// <param name="element">
        /// The element containing the error being reported.
        /// </param>
        /// <param name="type">
        /// The type to be stored in the validation error.
        /// </param>
        /// <param name="message">
        /// The message to be stored in the validation error.
        /// </param>
        internal ElementValidationError(Element element, string type, string message)
            : base(type, message)
        {
            this.Element = element;
        }

        /// <summary>
        /// Class constructor. This constructor will store a message and an exception.
        /// </summary>
        /// <param name="element">
        /// The element containing the error being reported.
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
        internal ElementValidationError(Element element, string type, string message, Exception exception)
            : base(type, message, exception)
        {
            this.Element = element;
        }
    }
}
