using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
	{
		PortfolioManager pm = new PortfolioManager(new EfPortfolioRepository());
		public IActionResult Index()
		{
			var values = pm.GetList();
			return View(values);
		}

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Portfolio portfolio)
        {
            pm.TAdd(portfolio);
            return RedirectToAction("Index", "Portfolio");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = pm.GetId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Portfolio portfolio)
        {
            pm.TUpdate(portfolio);
            return RedirectToAction("Index", "Portfolio");
        }

        public IActionResult Delete(int id)
        {
            var values = pm.GetId(id);
            pm.TDelete(values);
            return RedirectToAction("Index", "Portfolio");
        }
    }
}
