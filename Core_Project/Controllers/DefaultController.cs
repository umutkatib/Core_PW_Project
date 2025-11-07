using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Project.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult NavbarPartial()
		{
			return PartialView();
		}
	}
}
