﻿namespace Managed.Adb.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    public class PermissionDeniedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDeniedException"/> class.
        /// </summary>
        public PermissionDeniedException()
            : base("Permission to access the specified resource was denied.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDeniedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public PermissionDeniedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDeniedException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization info.</param>
        /// <param name="context">The context.</param>
        public PermissionDeniedException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDeniedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public PermissionDeniedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
