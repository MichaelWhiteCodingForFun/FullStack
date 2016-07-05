using System;
using System.Web.Optimization;

namespace FullStack.App_Start
{
   public class BundleConfig
    {
       public static void RegisterBundles(BundleCollection bundles)
       {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Assets/lib/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
               "~/Assets/lib/angular/angular.js",
               "~/Assets/lib/angular-block-ui/dist/angular-block-ui.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Assets/styles/site.css",
                "~/Assets/styles/sortableGrid.css",
                "~/Assets/lib/bootstrap/dist/css/bootstrap.css",
                "~/Assets/lib/angular-block-ui/dist/angular-block-ui.min.css",
                "~/Assets/lib/angular-material/angular-material.min.css",
                "~/Assets/lib/angular-material/layouts/angular-material.layouts.min.css",
                "~/Assets/styles/main.css"));
        }
    }
}
