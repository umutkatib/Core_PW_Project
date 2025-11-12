using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace Core_Project.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		MessageManager messageManager = new MessageManager(new EfMessageDal());
		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
		//[HttpPost]
		//public IViewComponentResult Invoke(Message m)
		//{
		//	m.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
		//	m.MessageStatus = true;
		//	messageManager.TAdd(m);
		//	return View();
		//}
	}
}
