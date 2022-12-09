using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents
{
    public class Portfolio : ViewComponent
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
