using DwarfSelfies.Core.Domain;
using DwarfSelfies.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data;

namespace DwarfSelfies.Web.UI.Controllers
{
    public class SelfieController : Controller
    {
        public SelfieController(): base()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public IActionResult Index() // Action = par défaut au nom de ma vue.cshtml
        {
            List<Selfie> selfies = new()
            {
                new() { Titre = "T'as vu ma tetre" },
                new() { Titre = "Sauron n'a qu'à bien se tenir !" },
                new() { Titre = "Sauron n'a qu'à bien se tenir !" },
                new() { Titre = "Sauron n'a qu'à bien se tenir !" },
                new() { Titre = "Sauron n'a qu'à bien se tenir !" }
            };

            List<Location> locations = new()
            {
                new (1, "Mordor"),
                new (1, "Moria"),
            };

            this.ViewBag.IsMobileDevice = true;

            // return View(selfies);
            var model = new SelfieListViewModel();

            // Pour rappel sur le ? => donc teste si la propriété avant le ? est null // si null on n'appelle pas la propriété enfante
            //if(model.SelfieList?.Count > 0)
            //{

            //}


            // Car nous utilisons le model de type ViewModel
            return View("IndexAvecViewModel", new SelfieListViewModel() { SelfieList = selfies, IsMobile = true, LocationList = locations });
        }

        public IActionResult Selfie()
        { 
            return View(); 
        }
    }
}
