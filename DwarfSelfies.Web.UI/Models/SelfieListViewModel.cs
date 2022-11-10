using DwarfSelfies.Core.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DwarfSelfies.Web.UI.Models
{
    public class SelfieListViewModel
    {
        #region Constructors
        public SelfieListViewModel()
        {

            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7
            };

            var result = list.Select(item => item.ToString());

            // this.SelfieList = new List<Selfie>();
        }
        #endregion

        #region Properties
        public List<Selfie>? SelfieList { get; set; }

        public bool IsMobile { get; set; }

        private List<Location> locationList;
        public List<Location> LocationList 
        {
            get => this.locationList;
            set
            {
                this.locationList = value;
                this.LocationItems = this.locationList.Select(location => new SelectListItem()
                {
                    Selected = location.Id == 1,
                    Value = location.Id.ToString(),
                    Text = location.Libelle
                });
            }
        }

        public IEnumerable<SelectListItem> LocationItems { get; private set; }
        #endregion
    }
}
