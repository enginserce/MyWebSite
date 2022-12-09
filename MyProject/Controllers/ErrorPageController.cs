using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
	{
        [Route("errorpage/404")]
        public IActionResult NotFound(int code)
        {
            return View();
        }
        [Route("errorpage/403")]
        public IActionResult Forbidden(int code)
        {
            return View();
        }
    }
}
