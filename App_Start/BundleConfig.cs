using System.Web;
using System.Web.Optimization;

namespace Dynage
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Content/Theme/scripts").Include(
                        "~/Content/Theme/scripts/plugins.min.js",
                        "~/Content/Theme/scripts/theme.js",
                        "~/Content/Theme/scripts/demo-it-services.js",
                        "~/Content/Theme/scripts/theme.init.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //         "~/Content/Theme/css/bootstrap.min.css",
            //         //"~/Content/Theme/css/bootstrap.min.css",
            //         "~/Content/Theme/css/all.min.css",
            //         "~/Content/Theme/css/animate.compat.css",
            //         "~/Content/Theme/css/simple-line-icons.min.css",
            //         "~/Content/Theme/css/owl.carousel.min.css",
            //         "~/Content/Theme/css/owl.theme.default.min.css",
            //         "~/Content/Theme/css/magnific-popup.min.css"));

        }
    }
}
