﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace OpenSchool
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
	        config.EnableCors();
			config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

	        config.Formatters.Remove(config.Formatters.XmlFormatter);
	        config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
		}
    }
}
