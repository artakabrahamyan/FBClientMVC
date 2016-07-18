using System.Threading.Tasks;
using FBClientMVC.Core.Models.RestAPI.JSONRequest;
using FBClientMVC.Core.Models.RestAPI.JSONResponse;

namespace FBClientMVC.Core.Models.RestAPI.Interfaces
{
    public interface IFBWebAPIContract
    {
        Task<FBWebAPIResponse> CallWebAPIMethod(FBWebAPIRequest request);
    }
}
