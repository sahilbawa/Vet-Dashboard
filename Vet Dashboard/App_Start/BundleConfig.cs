using System.Web;
using System.Web.Optimization;

namespace Vet_Dashboard
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/JS/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/JS/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/JS/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/JS/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/datetimepicker").Include(
                      "~/Content/JS/moment.js",
                      "~/Content/JS/bootstrap-datetimepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                      "~/Content/JS/popper.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/CSS/bootstrap.css",
                      "~/Content/CSS/site.css"));

            bundles.Add(new StyleBundle("~/Content/css/datetimepicker").Include(
                      "~/Content/CSS/bootstrap-datetimepicker.css"));
        }
    }
}
