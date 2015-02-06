using System.Web;
using System.Web.Optimization;

namespace rpg
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modaljquery").Include(
                        "~/Scripts/bmodal.js"));

            bundles.Add(new ScriptBundle("~/bundles/Basejquery").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/Uteis.js"));

            bundles.Add(new StyleBundle("~/bundles/Logincss").Include(
                      "~/Content/Login.css"));

            bundles.Add(new StyleBundle("~/bundles/Basecss").Include(
                      "~/Content/Basico.css"));

            bundles.Add(new StyleBundle("~/bundles/gridcss").Include(
                     "~/Content/Grid.css"));

            bundles.Add(new StyleBundle("~/bundles/modalcss").Include(
                     "~/Content/Modal.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
