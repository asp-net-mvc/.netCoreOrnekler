using System.Web;
using System.Web.Optimization;

namespace cms
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
        
           // bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
           //              "~/Assets/plugins/jquery/jquery.js"));

           bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Assets/js/jquery.validate.js*"));


            //ScriptBundle scriptBundle = new ScriptBundle("~/bundles/js");
            //scriptBundle.Include("~/Assets/plugins/jquery/jquery.min.js");
            //scriptBundle.Include("~/Assets/plugins/bootstrap/js/bootstrap.bundle.min.js");
            //scriptBundle.Include("~/Assets/plugins/select2/js/select2.full.min.js");
            //scriptBundle.Include("~/Assets/plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js");
            //scriptBundle.Include("~/Assets/plugins/moment/moment.min.js");
            //scriptBundle.Include("~/Assets/plugins/inputmask/min/jquery.inputmask.bundle.min.js");
            //scriptBundle.Include("~/Assets/plugins/daterangepicker/daterangepicker.js");
            //scriptBundle.Include("~/Assets/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js");
            //scriptBundle.Include("~/Assets/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js");
            //scriptBundle.Include("~/Assets/plugins/bootstrap-switch/js/bootstrap-switch.min.js");
            //scriptBundle.Include("~/Assets/js/adminlte.min.js");
            //scriptBundle.Include("~/Assets/js/demo.js");
            ////Add the bundle into BundleCollection
            //bundles.Add(scriptBundle);




            bundles.Add(new ScriptBundle("~/bundles/myjs").Include(
                   "~/Assets/plugins/jquery/jquery.min.js",
            "~/Assets/plugins/bootstrap/js/bootstrap.bundle.min.js",
            "~/Assets/plugins/select2/js/select2.full.min.js",
            "~/Assets/plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js",
            "~/Assets/plugins/moment/moment.min.js",
            "~/Assets/plugins/inputmask/min/jquery.inputmask.bundle.min.js",
            "~/Assets/plugins/daterangepicker/daterangepicker.js",
            "~/Assets/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.js",
            "~/Assets/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
           "~/Assets/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
            "~/Assets/js/adminlte.min.js",
            "~/Assets/js/demo.js"));



            bundles.Add(new StyleBundle("~/Assets/css").Include(
                      "~/Assets/plugins/fontawesome-free/css/all.min.css",
                      "~/Assets//plugins/daterangepicker/daterangepicker.css",
                      "~/Assets/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                      "~/Assets/plugins/bootstrap-colorpicker/css/bootstrap-colorpicker.min.css",
                      "~/Assets/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/Assets/plugins/select2/css/select2.min.css",
                      "~/Assets/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css",
                      "~/Assets/plugins/bootstrap4-duallistbox/bootstrap-duallistbox.min.css",
                      "~/Assets/css/adminlte.min.css"));

           //   BundleTable.EnableOptimizations = true;

        }
    }
}
