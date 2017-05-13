namespace FClubBarcelona
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
           // RouteTable.Routes.MapHubs();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
        }
    }
}
