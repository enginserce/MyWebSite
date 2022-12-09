using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
	{
		ServicesManager sm = new ServicesManager(new EfServicesRepository());
		public IActionResult Index()
		{
			var values = sm.GetList();
			return View(values);
		}

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Services services)
        {
           sm.TAdd(services);
           return RedirectToAction("Index", "Services");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = sm.GetId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Services services)
        {
            sm.TUpdate(services);
            return RedirectToAction("Index", "Services");
        }

        public IActionResult Delete(int id)
        {
            var values = sm.GetId(id);
            sm.TDelete(values);
            return RedirectToAction("Index", "Services");
        }
    }
}
