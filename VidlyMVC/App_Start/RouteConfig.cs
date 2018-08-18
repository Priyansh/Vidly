using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidlyMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //Cretaed Custom Route --> Old Approach by Priyansh
            //Good practice to make Attribute Routing (MVC5)
            /*routes.MapRoute(
                "MyMoviesByReleaseDate", //Unique name
                "movies/releasedate/{month}/{year}",
                new { controller = "Movies", action = "ByReleaseDate" },
                new { month = @"\d{2}", year = @"\d{4}"});*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
