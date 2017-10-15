﻿using System.Web;
using System.Web.Optimization;

namespace MFU.WebAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                               "~/Scripts/ace-elements.min.js",
                               "~/Scripts/ace.min.js",
                               "~/Scripts/bootbox.js",
                               "~/Scripts/ace-extra.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/site.css",
                       "~/Content/font-awesome.min.css",
                       "~/Content/ace.min.css",
                       "~/Content/ace-rtl.min.css",
                       "~/Content/ace-skins.min.css"));
        }
    }
}
