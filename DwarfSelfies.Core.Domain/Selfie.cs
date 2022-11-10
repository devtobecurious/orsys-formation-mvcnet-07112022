namespace DwarfSelfies.Core.Domain
{
    /// <summary>
    /// Selfie à afficher et gérer
    /// </summary>
    public class Selfie
    {
        #region Constructors
        public Selfie(): this(string.Empty)
        {

        }

        public Selfie(string titre)
        {
            this.Titre = titre; 
        }
        #endregion

        #region Properties
        public decimal Id { get; set; }

        /// <summary>
        /// Titre du selfie
        /// </summary>
        public string Titre { get; init; } = string.Empty;
        #endregion
    }
}