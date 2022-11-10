using DwarfSelfies.Core.Domain;
using DwarfSelfies.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DwarfSelfies.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Debug.WriteLine("Hello ");

            // this._logger.LogCritical("Une info au passage");
        }

        public IActionResult Index()
        {
            List<Selfie> selfies = new()
            {
                new() { Titre = "T'as vu ma tetre" },
                new() { Titre = "Sauron n'a qu'à bien se tenir !" }
            };

            Selfie selfie = new() {  Titre = ""};
            //selfie.Titre = "";

            // var selfies2 = new List<Selfie>();

            // Possibilité non recommandée avec le ViewBag
            // this.ViewBag.SelfieList = selfies;

            // Découverte en passant par le model
            return View(selfies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}