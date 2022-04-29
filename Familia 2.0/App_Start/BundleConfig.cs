using System.Web;
using System.Web.Optimization;

namespace Familia_2._0
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

            bundles.Add(new StyleBundle("~/Content/Main/css").Include(
                      "~/Content/Main/bootstrap.css",
                      "~/Content/Main/site.css"));
            bundles.Add(new StyleBundle("~/Content/Custom/buttonBundle").Include(
                      "~/Content/Custom/buttonStyle.css",
                      "~/Content/OwlCarousel/owl.carousel.css",
                      "~/Content/Custom/featured-carousel.css",
                      "~/Content/CUstom/logos.css"));
        }
    }
}
