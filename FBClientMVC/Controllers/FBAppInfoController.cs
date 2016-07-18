using FBClientMVC.Core.Services;
using FBClientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;

namespace FBClientMVC.Controllers
{
    public class FBAppInfoController : Controller
    {
        private readonly IFBClientDispatcher _fbClientDispatcher;

        public FBAppInfoController(IFBClientDispatcher fbClientDispatcher)
        {
            _fbClientDispatcher = fbClientDispatcher;
        }

        // GET: FBAppInfo/SendFBCall
        public ActionResult SendFBCall()
        {
            return View();
        }

        // POST: FBAppInfo/SendFBCall
        [HttpPost]
        public async Task<ActionResult> SendFBCall(FBAppInfoModel fbAppInfoModel)
        {
            if (!ModelState.IsValid)
                return View(fbAppInfoModel);

            try
            {
                var result = await _fbClientDispatcher.CallFBWebAPI_CommentsAndSaveInXML_Method(fbAppInfoModel.AppID, fbAppInfoModel.AppSecretKey, fbAppInfoModel.PageID, fbAppInfoModel.TopicFilter);

                if (!result.Success)
                    ModelState.AddModelError("", result.Message);
                else
                    ViewBag.StatusMessage = result.Message;
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
    }
}
