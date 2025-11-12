using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SendMessage(Message m)
		{
			MessageManager messageManager = new MessageManager(new EfMessageDal());
			m.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			m.MessageStatus = true;
			messageManager.TAdd(m);
			return PartialView();
		}
	}
}
