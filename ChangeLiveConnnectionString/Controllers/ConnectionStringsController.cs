using ChangeLiveConnnectionString.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChangeLiveConnnectionString.Controllers
{
    public class ConnectionStringsController : Controller
    {
        private readonly IConnectionStringProvider provider;

        public ConnectionStringsController(IConnectionStringProvider provider)
        {
            this.provider = provider;
        }

        public IActionResult Index()
        {
            this.ViewBag.SelectedKey = this.provider.GetKey();

            return View(this.provider.GetKeys());
        }

        [HttpPost]
        public IActionResult Index(string key)
        {
            this.provider.Set(key);
            this.ViewBag.SelectedKey = this.provider.GetKey();

            return View(this.provider.GetKeys());
        }
    }
}
