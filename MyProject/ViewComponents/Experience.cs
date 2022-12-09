using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents
{
    public class Experience : ViewComponent
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
