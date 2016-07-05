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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
               "~/Assets/lib/bootstrap/dist/js/bootstrap.min.js",
               "~/Assets/lib/respondJS/dest/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
               "~/Assets/lib/angular/angular.js",
               "~/Assets/lib/angular-block-ui/dist/angular-block-ui.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Assets/styles/main.css", 
                "~/Assets/lib/bootstrap/dist/css/bootstrap.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
