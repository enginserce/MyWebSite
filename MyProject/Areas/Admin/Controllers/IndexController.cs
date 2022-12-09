using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IndexController : Controller
    {
        HelloManager hm = new HelloManager(new EfHelloRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = hm.GetList();
            ViewBag.v1 = c.Skillss.Count();
            ViewBag.v2 = c.Portfolios.Count();
            ViewBag.v3 = c.Contacts.Count();
            return View(values);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = hm.GetId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Hello hello)
        {
            hm.TUpdate(hello);
            return RedirectToAction("Index");
        }
    }
}
