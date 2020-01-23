using System.Web;
using System.Web.Optimization;

namespace Stor_Perde_Yikama
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //* Admin *//

            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/atlantis.min.css"));

            bundles.Add(new ScriptBundle("~/assets/js/core").Include(
                      "~/assets/js/core/jquery.3.2.1.min.js",
                      "~/assets/js/core/popper.min.js",
                      "~/assets/js/core/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/core/bootstrap").Include(
                      "~/assets/js/core/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/plugin").Include(
                      "~/assets/js/plugin/jquery-ui-1.12.1.custom/jquery-ui.min.js",
                      "~/assets/js/plugin/jquery-ui-touch-punch/jquery.ui.touch-punch.min.js",
                      "~/assets/js/plugin/jquery-scrollbar/jquery.scrollbar.min.js",
                      "~/assets/js/plugin/chart.js/chart.min.js",
                      "~/assets/js/plugin/jquery.sparkline/jquery.sparkline.min.js",
                      "~/assets/js/plugin/chart-circle/circles.min.js",
                      "~/assets/js/plugin/datatables/datatables.min.js",
                      "~/assets/js/plugin/bootstrap-notify/bootstrap-notify.min.js",
                      "~/assets/js/plugin/jqvmap/jquery.vmap.min.js",
                      "~/assets/js/plugin/jqvmap/maps/jquery.vmap.world.js",
                      "~/assets/js/plugin/sweetalert/sweetalert.min.js",
                      "~/assets/js/atlantis.min.js"
                      ));
        }
    }
}
