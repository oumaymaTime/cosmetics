using System.Web;
using System.Web.Optimization;

namespace CosmeticsApp
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template design
            bundles.Add(bundle: new ScriptBundle("~/template/js").Include(
                  "~/Scripts/modernizr.js",
                  "~/Scripts/jquery-1.10.2.min.js",
                  "~/Scripts/bootstrap.min.js",
                  "~/Scripts/owl.carousel.min.js",
                  "~/Scripts/html5lightbox.js",
                  "~/Scripts/scrolly.js",
                  "~/Scripts/price-range.js",
                  "~/Scripts/script.js",
                  "~/Scripts/rs-plugin/js/jquery.themepunch.tools.min.js",
                  "~/Scripts/rs-plugin/js/jquery.themepunch.revolution.min.js"
                  ));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/fonts/font-awesome/css/font-awesome.min.css",
                      "~/fonts/themify-icons/themify-icons.css",
                      "~/Content/css/owl.carousel.css",
                      "~/Content/css/price-range.css",
                      "~/Content/css/style.css",
                      "~/Content/css/responsive.css",
                      "~/Content/css/colors.css",
                      "~/Content/css/owl.theme.css"
                      ));
            #endregion
        }
    }
}