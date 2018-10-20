using System.Web.Optimization;

namespace Greencard.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/core").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/all.min.css",
                      "~/Content/style.css"));

            bundles.Add(new ScriptBundle("~/Scripts/core").Include(
                      "~/Scripts/jquery-{version}.min.js",
                      "~/Scripts/modernizr-*",
                      "~/Scripts/jquery.validate*",
                      "~/Scripts/bootstrap.bundle.min.js",
                      "~/Scripts/all.min.js*",
                      "~/Scripts/main.js*"));

            BundleTable.EnableOptimizations = true;
        }
    }
}