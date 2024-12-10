using System;
using System.Web.Http;

public static class WebApiConfig
{
    public const string UrlPrefix = "api";
    public const string UrlPrefixRelative = "~/api";

    public static void Register(HttpConfiguration config)
    {
        // Web API configuration and services
        config.Filters.Add(new AuthorizeAttribute());

        // Web API routes
        config.MapHttpAttributeRoutes();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: UrlPrefix + "/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
    }
}