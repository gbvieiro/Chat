using Chat.Application.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers
{
    /// <summary>
    /// This is a base controller, all other controllers must inherit this class.
    /// </summary>
    [EnableCors]
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        protected BaseController() { }

        /// <summary>
        /// This method could be used to respond for the clients with a json,
        /// </summary>
        /// <param name="jsonValues">
        /// A object that represents the json file structure.
        /// </param>
        /// <param name="statusCode">
        /// The status code of the response.
        /// </param>
        /// <returns>A json that represents the response of the API.</returns>
        protected JsonResult ResponseWithJson(object? jsonValues, StatusCodeEnum statusCode)
        {
            Response.StatusCode = (int)statusCode;
            return Json(jsonValues);
        }
    }
}