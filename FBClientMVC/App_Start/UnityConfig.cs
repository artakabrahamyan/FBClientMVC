using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using FBClientMVC.Core.Models.RestAPI.Interfaces;
using FBClientMVC.Core.Managers.RestAPI;
using FBClientMVC.Core.Services.RestAPI;
using FBClientMVC.Core.Services;
using FBClientMVC.Controllers;

namespace FBClientMVC
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			container.RegisterType<IErrorResponseBuilder, ErrorResponseBuilder>();
			container.RegisterType<IRestClientService, RestClientService>();
			container.RegisterType<IRestRequestService, RestRequestService>();

			container.RegisterType<IFBWebAPIContract, FBWebAPIManager>();
			container.RegisterType<IFBClientDispatcher, FBClientDispatcher>();

			container.RegisterType<FBAppInfoController>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}