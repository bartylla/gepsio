using System;

namespace JeffFerguson.Gepsio
{
    /// <summary>
    /// The class for all validation errors discovered in the schema of a loaded document.
    /// </summary>
    public class SchemaValidationError : ValidationError
    {
        /// <summary>
        /// The schema containing the error being reported.
        /// </summary>
        public XbrlSchema Schema { get; private set; }

        /// <summary>
        /// Class constructor. This constructor will store a message and will automatically set the
        /// Exception property to a null value.
        /// </summary>
        /// <param name="schema">
        /// The schema containing the error being reported.
        /// </param>
        /// <param name="type">
        /// The type to be stored in the validation error.
        /// </param>
        /// <param name="message">
        /// The message to be stored in the validation error.
        /// </param>
        internal SchemaValidationError(XbrlSchema schema, string type, string message)
            : base(type, message)
        {
            this.Schema = schema;
        }

        /// <summary>
        /// Class constructor. This constructor will store a message and an exception.
        /// </summary>
        /// <param name="schema">
        /// The schema containing the error being reported.
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
        internal SchemaValidationError(XbrlSchema schema, string type, string message, Exception exception)
            : base(type, message, exception)
        {
            this.Schema = schema;
        }
    }
}
