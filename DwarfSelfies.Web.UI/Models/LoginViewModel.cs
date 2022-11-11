using System.ComponentModel.DataAnnotations;

namespace DwarfSelfies.Web.UI.Models
{
    public class LoginViewModel
    {
        #region Properties
        [Required(AllowEmptyStrings = false, ErrorMessage = "Champs requis" )] 
        public string Login { get; set; }

        [DataType(DataType.Password)]   
        public string Password { get; set; }
        #endregion
    }
}
