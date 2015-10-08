using System.Web;
using System.Web.Optimization;

namespace Portaria.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/material/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js",
                    "~/material/vendors/bower_components/jquery/dist/jquery.min.js",
                    "~/material/vendors/bower_components/flot/jquery.flot.js",
                    "~/material/vendors/bower_components/flot/jquery.flot.resize.js",
                    "~/material/vendors/bower_components/flot.curvedlines/curvedLines.js",
                    "~/material/vendors/sparklines/jquery.sparkline.min.js",
                    "~/material/vendors/bower_components/jquery.easy-pie-chart/dist/jquery.easypiechart.min.js",
                    "~/material/vendors/bower_components/moment/min/moment.min.js",
                    "~/material/vendors/bower_components/fullcalendar/dist/fullcalendar.min.js ",
                    "~/material/vendors/bower_components/simpleWeather/jquery.simpleWeather.min.js",
                    "~/material/vendors/bower_components/jquery.nicescroll/jquery.nicescroll.min.js",
                    "~/material/vendors/bower_components/Waves/dist/waves.min.js",
                    "~/material/vendors/bootstrap-growl/bootstrap-growl.min.js",
                    "~/material/vendors/bower_components/bootstrap-sweetalert/lib/sweet-alert.min.js",
                    "~/material/js/flot-charts/curved-line-chart.js",
                    "~/material/js/flot-charts/line-chart.js",
                    "~/material/js/charts.js",
                    "~/material/js/functions.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/material/vendors/bower_components/fullcalendar/dist/fullcalendar.min.css",
                      "~/material/vendors/bower_components/bootstrap-sweetalert/lib/sweet-alert.css",
                      "~/material/vendors/bower_components/fullcalendar/dist/fullcalendar.min.css",
                      "~/material/css/app.min.1.css",
                      "~/material/css/app.min.2.css",
                      "~/material/vendors/bower_components/animate.css/animate.min.css",
                      "~/material/vendors/bower_components/material-design-iconic-font/dist/css/material-design-iconic-font.min.css"));
        }
    }
}
