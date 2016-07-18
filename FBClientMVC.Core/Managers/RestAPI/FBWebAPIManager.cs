using System.Threading.Tasks;
using FBClientMVC.Core.Constants.RestAPI;
using FBClientMVC.Core.Models.RestAPI.Interfaces;
using FBClientMVC.Core.Models.RestAPI.JSONRequest;
using FBClientMVC.Core.Models.RestAPI.JSONResponse;
using FBClientMVC.Core.Services.RestAPI;

namespace FBClientMVC.Core.Managers.RestAPI
{
    /// <summary>
    /// Manager class to prepare and request the data from WebAPI server.
    /// </summary>
    public class FBWebAPIManager : IFBWebAPIContract
    {
        private readonly IRestRequestService _restRequestService;

        public FBWebAPIManager(IRestRequestService restRequestService)
        {
            _restRequestService = restRequestService;
        }
        
        /// <summary>
        /// Call WebAPI method.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FBWebAPIResponse> CallWebAPIMethod(FBWebAPIRequest request)
        {
            var apiUrlPath = string.Format(URLConstants.FB_GET_SAVE_INFO_ACTION_ABSOLUTE_PATH_SUFFIX, request.AppID, request.AppSecretKey, request.PageId, request.TopicFilter);
            return await _restRequestService.BuildEmptyRequest<FBWebAPIResponse>(apiUrlPath, null);
        }
    }
}
