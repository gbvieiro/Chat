namespace Chat.Application.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <typeparam name="T">The type of return.</typeparam>
    public class ApplicationResponse<T> : ApplicationResponse
    {
        /// <summary>
        /// Indicates if the response has a value.
        /// </summary>
        public bool HasValue { get; private set; }

        /// <summary>
        /// The response value.
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public static ApplicationResponse<T> CreateErrorWithType(
            string errorMessage,
            StatusCodeEnum statusCode = StatusCodeEnum.InternalServerError
        ) => new()
        {
            HasError = true,
            HasValue = false,
            ErrorMessage = errorMessage,
            StatusCode = statusCode
        };

        /// <summary>
        /// Explicit operator convertApplicationResponse<value> to value.
        /// </summary>
        /// <param name="optional">An AplicationResponse object.</param>
        public static explicit operator T(ApplicationResponse<T> optional)
        {
            return optional.Value;
        }

        /// <summary>
        /// Explicit operator value to convertApplicationResponse<value>.
        /// </summary>
        /// <param name="value">The value to convert to the AplicationResponse object.</param>
        public static implicit operator ApplicationResponse<T>(T value)
        {
            return new ApplicationResponse<T>()
            {
                HasValue = true,
                Value = value,
                ErrorMessage = string.Empty,
                HasError = false,
                StatusCode = StatusCodeEnum.OK
            };
        }
    }
}