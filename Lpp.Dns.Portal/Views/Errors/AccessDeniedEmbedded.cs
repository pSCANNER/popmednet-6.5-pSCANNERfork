﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.Portal.Views.Errors {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using Lpp;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Dns;
    using Lpp.Dns.Model;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Views;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Controllers;
    
    
    public partial class AccessDeniedEmbedded : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden

        
        public AccessDeniedEmbedded() {
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

            
            #line 1 "D:\Lincoln Peak\PMN\Dns\Lpp.Dns.Portal\Views\Errors\AccessDeniedEmbedded.cshtml"
   Layout = null; 

            
            #line default
            #line hidden
WriteLiteral("You do not have a permission to perform this operation.<br />\r\nIf you believe thi" +
"s is a mistake, please contact your administrator.");


        }
    }
}