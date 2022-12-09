using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents
{
    public class Footer : ViewComponent
    {
        HelloManager hm = new HelloManager(new EfHelloRepository());
        public IViewComponentResult Invoke()
        {
            var values = hm.GetList();
            return View(values);
        }
    }
}
