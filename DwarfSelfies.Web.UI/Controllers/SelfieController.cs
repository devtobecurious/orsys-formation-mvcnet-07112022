using DwarfSelfies.Core.Domain;
using DwarfSelfies.Core.Interfaces.Repositories;
using DwarfSelfies.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data;

namespace DwarfSelfies.Web.UI.Controllers
{
    public class SelfieController : Controller
    {
        private readonly DwarfSelfies.Core.Interfaces.ILogger logger;
        private readonly ISelfieRepository repository;

        public SelfieController(DwarfSelfies.Core.Interfaces.ILogger logger,
                                ISelfieRepository repository) : base()
        {
            this.logger = logger;
            this.repository = repository;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public IActionResult Index() // Action = par défaut au nom de ma vue.cshtml
        {
            this.logger.Log("Je passe par index");

            //List<Selfie> selfies = new()
            //{
            //    new() { Titre = "T'as vu ma tetre" },
            //    new() { Titre = "Sauron n'a qu'à bien se tenir !" },
            //    new() { Titre = "Sauron n'a qu'à bien se tenir !" },
            //    new() { Titre = "Sauron n'a qu'à bien se tenir !" },
            //    new() { Titre = "Sauron n'a qu'à bien se tenir !" }
            //};

            // Le ToList (puisque lié à mon DbSet) va ouvrir la connection, faire la requete, itérer sur la requete
            // et retourner la list des instances de Selfies, renseignées par les data venant de sql
            //List<Selfie> selfies = this.context.Selfies.ToList(); // A ne pas reproduire en prod :D


            //foreach (var item in this.context.Selfies.Where(item => item.Id < 20))
            //{

            //}

            //var query = from item in this.context.Selfies
            //            where item.Id < 20
            //            select item;

            // var prepareFiltreQuery = query.Take(10);


            // Ici on exécute la requete autogénérée (avec le .ToList)
            // selfies = prepareFiltreQuery.ToList();

            // var lePremierSelfie = prepareFiltreQuery.First(); // Ici c'est le first qui exécute la requête


            List<Location> locations = new List<Location>(); // this.context.Locations.ToList();

            this.ViewBag.IsMobileDevice = true;

            // return View(selfies);
            var model = new SelfieListViewModel();

            // Pour rappel sur le ? => donc teste si la propriété avant le ? est null // si null on n'appelle pas la propriété enfante
            //if(model.SelfieList?.Count > 0)
            //{

            //}

            List<Selfie> selfies = this.repository.GetAll();

            // Car nous utilisons le model de type ViewModel
            return View("IndexAvecViewModel", new SelfieListViewModel() { SelfieList = selfies, IsMobile = true, LocationList = locations });
        }

        public IActionResult Selfie()
        { 
            return View(); 
        }
    }
}
