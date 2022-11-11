using DwarfSelfies.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DwarfSelfies.Web.UI.Controllers
{
    public class ClassALarrache
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class AuthenticateController : Controller
    {
        #region Public methods
        [HttpGet]
        public IActionResult Login()
        {
            // Pour envoyer le html de la page
            return View();
        }

        [HttpPost]
        // public IActionResult Login(string password, string login)
        //public IActionResult Login(ClassALarrache item)
        public IActionResult Login(LoginViewModel item)
        {
            IActionResult result = this.View();

            // Pour récupérer le contenu si plusieurs fois le même name 
            var listValues = this.Request.Form["login"].ToArray();

            if(this.ModelState.IsValid)
            {
                // On va se logger
                //if( this.authRepo.login(login, password))
                //{

                //}

                

                result = this.RedirectToAction("Index", "Selfie", new { id= "a" });
            }


            return result;
        }
        #endregion
    }
}
