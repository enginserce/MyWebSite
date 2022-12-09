using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MyProject.ViewComponents;
using Skills = EntityLayer.Concrete.Skills;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillsController : Controller
	{
		SkillsManager sm = new SkillsManager(new EfSkillsRepository());
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
        public IActionResult Add(Skills skills)
        {
            sm.TAdd(skills);
            return RedirectToAction("Index", "Skills");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = sm.GetId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Skills skills)
        {
            sm.TUpdate(skills);
            return RedirectToAction("Index", "Skills");
        }

        public IActionResult Delete(int id)
        {
            var values = sm.GetId(id);
            sm.TDelete(values);
            return RedirectToAction("Index", "Skills");
        }
    }
}
