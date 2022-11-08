using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class AdminController1 : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
