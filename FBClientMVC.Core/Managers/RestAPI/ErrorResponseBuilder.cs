using FBClientMVC.Core.Models.RestAPI.Interfaces;
using FBClientMVC.Core.Models.RestAPI.JSONError;

namespace FBClientMVC.Core.Managers.RestAPI
{
    public class ErrorResponseBuilder : IErrorResponseBuilder
    {
        /// <summary>
        /// Create an ErrorDetail object.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="errorDescription"></param>
        /// <returns></returns>
        public ErrorDetail BuildErrorResponse(int statusCode, string errorDescription)
        {
            return new ErrorDetail
            {
                code = statusCode,
                message = errorDescription
            };
        }
    }
}
