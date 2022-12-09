using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MyProject.ViewComponents
{
    public class Skills : ViewComponent
    {
        SkillsManager sm = new SkillsManager(new EfSkillsRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
