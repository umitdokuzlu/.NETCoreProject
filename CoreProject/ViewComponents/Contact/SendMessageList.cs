using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.ViewComponents.Contact
{
    public class SendMessageList:ViewComponent
    {
        SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    sendMessageManager.TAdd(p);
        //    return View();
        //}
    }
}
