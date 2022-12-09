using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents
{
    public class Services : ViewComponent
    {
        ServicesManager sm = new ServicesManager(new EfServicesRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
