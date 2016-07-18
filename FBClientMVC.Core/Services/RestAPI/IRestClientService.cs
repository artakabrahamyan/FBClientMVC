using FBClientMVC.Core.Models.RestAPI.JSONResponse;
using System.Threading.Tasks;

namespace FBClientMVC.Core.Services.RestAPI
{
    public interface IRestClientService
    {
        /// <summary>
        /// Get method of Web API request and return generic type of object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="urlSegment"></param>
        /// <param name="userAgent"></param>
        /// <param name="cookie"></param>
        /// <returns></returns>
        Task<T> Get<T>(string urlSegment, string userAgent, string cookie) where T : BaseResponse, new();
    }
}
