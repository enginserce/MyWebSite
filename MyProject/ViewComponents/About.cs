using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents
{
    public class About : ViewComponent
    {
        AboutManager am = new AboutManager(new EfAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = am.GetList();
            return View(values);
        }
    }
}
