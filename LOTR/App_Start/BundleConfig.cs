using System.Web;
using System.Web.Optimization;

namespace LOTR
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/text_style.CSS",
                "~/Content/link_color.CSS",
                "~/Content/dropbtn.CSS",
                "~/Content/tabstyle.CSS"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/hideTab.js",
                "~/Scripts/hideTab1.js",
                "~/Scripts/hideTab2.js",
                "~/Scripts/imagezoom.js"));
        }
    }
}