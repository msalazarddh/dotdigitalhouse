using System.Web;
using System.Web.Optimization;

namespace DotDigitalHouse
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
    
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/js/lib/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/siteJs").Include(
                      "~/Content/js/lib/jquery.min.js",
                      "~/Content/js/lib/respond.min.js",
                      "~/Content/js/lib/bootstrap.bundle.min.js",
                      "~/Content/js/lib/easing.min.js",
                      "~/Content/js/lib/superfish.min.js",
                      "~/Content/js/lib/wow.min.js",
                      "~/Content/js/lib/waypoints.min.js", 
                      "~/Content/js/lib/owl.carousel.min.js",
                      "~/Content/js/lib/isotope.pkgd.min.js", 
                      "~/Content/js/lib/lightbox.min.js",
                      "~/Content/js/lib/jquery.touchSwipe.min.js",
                      "~/Content/js/lib/particles.min.js", 
                      "~/Content/js/lib/app.min.js",
                      "~/Content/js/contactform.js",
                      "~/Content/js/main.js")); 

            bundles.Add(new StyleBundle("~/Content/siteCss").Include(
                      "~/Content/css/lib/bootstrap.min.css",
                      "~/Content/css/lib/font-awesome.csSs",
                      "~/Content/css/lib/animate.min.css",
                      "~/Content/css/lib/ionicons.css",
                      "~/Content/css/lib/owl.carousel.min.css",
                      "~/Content/css/lib/lightbox.min.css",
                      "~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/404Css").Include(
                      "~/Content/css/lib/bootstrap.min.css",
                      "~/Content/css/error.css"));

            bundles.Add(new ScriptBundle("~/bundles/404Js").Include(
            "~/Content/js/lib/particles.min.js",
                      "~/Content/js/lib/app.min.js",
                       "~/Content/js/error.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
