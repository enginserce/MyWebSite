using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
	{
		ExperienceManager em = new ExperienceManager(new EfExperienceRepository());
		public IActionResult Index()
		{
			var values = em.GetList();
			return View(values);
		}

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Experience experience)
        {
            em.TAdd(experience);
            return RedirectToAction("Index", "Experience");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var values = em.GetId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            em.TUpdate(experience);
            return RedirectToAction("Index", "Experience");
        }

        public IActionResult Delete(int id)
        {
            var values = em.GetId(id);
            em.TDelete(values);
            return RedirectToAction("Index", "Experience");
        }
    }
}
