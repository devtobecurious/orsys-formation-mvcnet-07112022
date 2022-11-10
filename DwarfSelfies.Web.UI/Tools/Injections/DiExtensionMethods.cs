namespace DwarfSelfies.Web.UI.Tools.Injections
{
    public static class DiExtensionMethods
    {
        #region Public methods
        public static void DefineCustomInjections(this IServiceCollection services)
        {
            services.AddSingleton<DwarfSelfies.Core.Interfaces.ILogger,
                              DwarfSelfies.Core.Infrastructures.Logging.ApiLogger>();

            services.AddScoped<DwarfSelfies.Core.Interfaces.DataLayers.ISelfieDataLayer,
                                          DwarfSelfies.Core.Infrastructures.Data.DataLayers.SelfieDataLayer>();

            services.AddScoped<DwarfSelfies.Core.Interfaces.Repositories.ISelfieRepository,
                                          DwarfSelfies.Core.Application.Selfies.SelfieRepository>();
        }
        #endregion
    }
}
