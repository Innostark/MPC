﻿using System.Web.Optimization;

namespace MPC.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            /* ============================================================== */
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                         "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
            /* ============================================================== */

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            /* ============================================================== */
            bundles.Add(new ScriptBundle("~/Content/themes/Centaurus/js").Include(
                        "~/Content/themes/Centaurus/js/*.js"));

            /* ============================================================== */


            bundles.Add(new ScriptBundle("~/Bundle/BaseLibs")
                .Include("~/Scripts/jquery-ui-1.10.4.js")
                .Include("~/Scripts/json2.js")
                .Include("~/Scripts/knockout-3.1.0.js")
                .Include("~/Scripts/knockout.mapping-latest.js")
                .Include("~/Scripts/knockout.validation.js")
                .Include("~/Scripts/underscore.js")
                .Include("~/Scripts/underscore-ko-1.6.0.js")
                .Include("~/Scripts/moment.js")
                .Include("~/Scripts/toastr.js")
                .Include("~/Scripts/require.js")
                .Include("~/Scripts/amplify.js")
                .Include("~/Scripts/respond.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css", "~/Content/site.css"));

            
        

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                                        "~/Content/themes/base/jquery.ui.core.css",
                                        "~/Content/themes/base/jquery.ui.resizable.css",
                                        "~/Content/themes/base/jquery.ui.selectable.css",
                                        "~/Content/themes/base/jquery.ui.accordion.css",
                                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                                        "~/Content/themes/base/jquery.ui.button.css",
                                        "~/Content/themes/base/jquery.ui.dialog.css",
                                        "~/Content/themes/base/jquery.ui.slider.css",
                                        "~/Content/themes/base/jquery.ui.tabs.css",
                                        "~/Content/themes/base/jquery.ui.datepicker.css",
                                        "~/Content/themes/base/jquery.ui.progressbar.css",
                                        "~/Content/themes/base/jquery.ui.theme.css"));

        }
    }
}
