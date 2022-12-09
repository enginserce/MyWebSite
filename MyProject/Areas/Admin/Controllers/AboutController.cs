using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
	{
		AboutManager am = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values = am.GetList();
			return View(values);
		}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = am.GetId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(About about)
        {
            am.TUpdate(about);
            return RedirectToAction("Index", "About");
        }
    }
}
