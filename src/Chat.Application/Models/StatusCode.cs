namespace Chat.Application.Models
{
    /// <summary>
    /// All posible status codes.
    /// </summary>
    public enum StatusCodeEnum
    {
        BadRequest = 400,
        Created = 201,
        NoContent = 204,
        Forbidden = 403,
        NotFound = 404,
        OK = 200,
        Unauthorized = 401,
        InternalServerError = 500
    }
}