using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ContactController : Controller
    {
        SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values=sendMessageManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var values = sendMessageManager.TGetByID(id);
            sendMessageManager.TDelete(values); 
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var values = sendMessageManager.TGetByID(id);
            return View(values);
        }
    }
}
