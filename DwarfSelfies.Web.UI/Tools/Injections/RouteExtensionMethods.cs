namespace DwarfSelfies.Web.UI.Tools.Injections
{
    public static class RouteExtensionMethods
    {
        public static void DefineCustomRoutes(this WebApplication app)
        {
            //app.MapGet("*.pdf", () =>
            //{

            //});

            app.MapControllerRoute(
                name: "selfieList",
                pattern: "les-selfies/{id}",
                defaults: new { controller = "Selfie", action = "Index" });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Authenticate}/{action=Login}/{id?}");
        }
    }
}
