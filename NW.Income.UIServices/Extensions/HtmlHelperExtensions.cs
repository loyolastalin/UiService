using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace NW.Income.UIServices.Extensions
{
    public static  class HtmlHelperExtensions
    {
        public static IHtmlString InlineStyles(this HtmlHelper htmlHelper, string applicationId)
        {
            var styleUrl = @"<link href='http://localhost:50701/Content/bootstrap.css' rel='stylesheet' />";
            styleUrl += Environment.NewLine;
            styleUrl += @"<link href='http://localhost:50701/Content/site.css' rel='stylesheet' />";
            styleUrl += Environment.NewLine;
            string baseUrl = htmlHelper.ViewContext.HttpContext.Request.Url.Host;
            if (applicationId == "1")
            {
                styleUrl += @"<link href='http://localhost:50701/Content/blueTheme.css' rel='stylesheet' />";
            }
            else if(applicationId == "2")
            {
                styleUrl += @"<link href='http://localhost:50701/Content/redTheme.css' rel='stylesheet' />";
            }
            else
            {
                styleUrl += @"<link href='http://localhost:50701/Content/defaultTheme.css' rel='stylesheet' />";
            }
            //return htmlHelper.InlineBundle(bundleVirtualPath, htmlTagName: "style");
            return new HtmlString(styleUrl);
        }

        private static IHtmlString InlineBundle(this HtmlHelper htmlHelper, string bundleVirtualPath, string htmlTagName)
        {
          //  string bundleContent = LoadBundleContent(htmlHelper.ViewContext.HttpContext, bundleVirtualPath);
           // string htmlTag = string.Format("<{0}>{1}</{0}>", htmlTagName, bundleContent);
            string xx = @"<link href='/Content/blueTheme.css' rel='stylesheet' />";
            return new HtmlString(xx);
        }

        private static string LoadBundleContent(HttpContextBase httpContext, string bundleVirtualPath)
        {
            var bundleContext = new BundleContext(httpContext, BundleTable.Bundles, bundleVirtualPath);

            var bundle = BundleTable.Bundles.Single(b => b.Path == bundleVirtualPath);
            var bundleResponse = bundle.GenerateBundleResponse(bundleContext);

            return bundleResponse.Content;
        }
    }
}