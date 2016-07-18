using FBClientMVC.Core.Models.FBClientMVC.Core;
using System.Threading.Tasks;

namespace FBClientMVC.Core.Services
{
    public interface IFBClientDispatcher
    {
        /// <summary>
        /// Send Application ID, Application Secret Key, Facebook Page ID and posted topic'c filter to WebAPI method.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecretKey"></param>
        /// <param name="pageId"></param>
        /// <param name="feedFilter"></param>
        /// <returns></returns>
        Task<FBClientModel> CallFBWebAPI_CommentsAndSaveInXML_Method(string appId, string appSecretKey, string pageId, string topicFilter);
    }
}
