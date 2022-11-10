using ChangeLiveConnnectionString.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChangeLiveConnnectionString.Controllers
{
    public class TestController : Controller
    {
        private readonly DefaultDbContext context;

        public TestController(DefaultDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(this.context.Selfie.ToList());
        }

    }
}
