using System.Web.Optimization;
using System.Web.UI;

public static class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        // WebForms JS
        bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                        "~/Scripts/WebForms/WebForms.js",
                        "~/Scripts/WebForms/WebUIValidation.js",
                        "~/Scripts/WebForms/MenuStandards.js",
                        "~/Scripts/WebForms/Focus.js",
                        "~/Scripts/WebForms/GridView.js",
                        "~/Scripts/WebForms/DetailsView.js",
                        "~/Scripts/WebForms/TreeView.js",
                        "~/Scripts/WebForms/WebParts.js"));

        // MsAjax JS
        // Order is very important for these files to work, they have explicit dependencies
        bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

        // Never use CDN
        bundles.UseCdn = false;
    }

    public static void RegisterScriptResourceDefinitions(ScriptResourceMapping mapping)
    {

    }
}
