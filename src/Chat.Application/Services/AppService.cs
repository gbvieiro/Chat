using AutoMapper;
using Chat.Application.Models;

namespace Chat.Application.Services
{
    /// <summary>
    /// A base app service. All other application services must inerit from it. 
    /// </summary>
    public abstract class AppService
    {
        /// <summary>
        /// The current mapper service.
        /// </summary>
        protected readonly IMapper Mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mapper">
        /// The mapper service provide by the IOC.
        /// </param>
        public AppService(IMapper mapper)
        {
            Mapper = mapper;
        }

        /// <summary>
        /// This method provide responses on the App Service.
        /// Use this to have the standart response and to void exceptions out of
        /// the application scope.
        /// </summary>
        /// <typeparam name="ResponseType">
        /// The method response type.
        /// </typeparam>
        /// <param name="action">
        /// The action to execute.
        /// </param>
        /// <returns>
        /// A new application response.
        /// </returns>
        protected async static Task<ApplicationResponse<ResponseType>> ExecuteAction<ResponseType>(
            Func<Task<ApplicationResponse<ResponseType>>> action
        )
        {
            try
            {
                return await action();
            }
            catch (Exception error)
            {
                return ApplicationResponse<ResponseType>.CreateErrorWithType(error.Message);
            }
        }

        /// <summary>
        /// This method provide responses on the App Service.
        /// Use this to have the standart response and to void exceptions out of
        /// the application scope.
        /// </summary>
        /// <param name="action">
        /// The action to execute.
        /// </param>
        /// <returns>
        /// A new application response.
        /// </returns>
        protected async static Task<ApplicationResponse> ExecuteAction(
            Func<Task<ApplicationResponse>> action
        )
        {
            try
            {
                return await action();
            }
            catch (Exception error)
            {
                return ApplicationResponse.CreateError(error.Message);
            }
        }
    }
}