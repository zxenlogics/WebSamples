﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WebMatrix.WebData;

using eSamples.Domain;

namespace eSamples.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {            
            SimpleMembershipInitializer.InitializeSimpleMembership();
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }

     public static class SimpleMembershipInitializer
     {
         public static void InitializeSimpleMembership()
         {
             Database.SetInitializer<eSamplesDb>(null);

             try
             {
                 using (var context = new eSamplesDb())
                 {
                     if (!context.Database.Exists())
                     {
                         // Create the SimpleMembership database without Entity Framework migration schema
                         ((IObjectContextAdapter)context).ObjectContext.CreateDatabase();
                     }
                 }

                 WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
             }
             catch (Exception ex)
             {
                 throw new InvalidOperationException("The ASP.NET Simple Membership database could not be initialized. For more information, please see http://go.microsoft.com/fwlink/?LinkId=256588", ex);
             }
         }
     }
}