namespace Chat.Application.Models
{
    /// <summary>
    /// Use this class to standardize the application responses.
    /// </summary>
    public class ApplicationResponse
    {
        /// <summary>
        /// The response status code.
        /// </summary>
        public StatusCodeEnum StatusCode { get; protected set; }

        /// <summary>
        /// Indicates if there are erros on the response
        /// </summary>
        public bool HasError { get; protected set; }

        /// <summary>
        /// A error message.
        /// </summary>
        public string ErrorMessage { get; protected set; }

        /// <summary>
        /// Create a error response.
        /// </summary>
        /// <param name="errorMessage">A error message.</param>
        /// <param name="statusCode">A status code.</param>
        /// <returns>A new error response.</returns>
        public static ApplicationResponse CreateError(
            string errorMessage,
            StatusCodeEnum statusCode = StatusCodeEnum.InternalServerError) => new()
            {
                HasError = true,
                ErrorMessage = errorMessage,
                StatusCode = statusCode
            };

        /// <summary>
        /// Create a success response.
        /// </summary>
        /// <param name="statusCode">A status code.</param>
        /// <returns>A new success response.</returns>
        public static ApplicationResponse CreateSuccess(
            StatusCodeEnum statusCode = StatusCodeEnum.OK) => new()
            {
                HasError = false,
                StatusCode = statusCode
            };
    }
}