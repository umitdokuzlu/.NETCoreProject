using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = sendMessageManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
