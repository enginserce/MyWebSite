using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());
		public IActionResult Index()
		{
			var values = cm.GetList();
			return View(values);
		}
        public IActionResult Delete(int id)
        {
            var values = cm.GetId(id);
            cm.TDelete(values);
            return RedirectToAction("Index", "Contact");
        }
        public IActionResult Details(int id)
        {
            var values = cm.GetId(id);
            return View(values);
        }
    }
}
