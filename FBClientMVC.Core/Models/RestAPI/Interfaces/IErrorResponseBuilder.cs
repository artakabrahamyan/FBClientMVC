﻿using FBClientMVC.Core.Models.RestAPI.JSONError;

namespace FBClientMVC.Core.Models.RestAPI.Interfaces
{
    public interface IErrorResponseBuilder
    {
        /// <summary>
        /// Create ErrorDetail object
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="errorDescription"></param>
        /// <returns></returns>
        ErrorDetail BuildErrorResponse(int statusCode, string errorDescription);
    }
}
