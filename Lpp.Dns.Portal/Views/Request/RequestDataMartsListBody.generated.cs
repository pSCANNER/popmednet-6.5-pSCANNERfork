﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.Portal.Views.Request
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns;
    using Lpp.Dns.Data;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Controllers;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Views;
    
    #line 2 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
    using Lpp.Dns.Portal.Views.Request;
    
    #line default
    #line hidden
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    #line 3 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
    using Lpp.Utilities.Legacy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Request/RequestDataMartsListBody.cshtml")]
    public partial class RequestDataMartsListBody : System.Web.Mvc.WebViewPage<RequestDataMartsListModel>
    {
        public RequestDataMartsListBody()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
   Layout = null; 
            
            #line default
            #line hidden
WriteLiteral(" \r\n\r\n");

            
            #line 6 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
Write(Html.Partial<DataMartsListBody>().WithModel( new DataMartsListModel
{
    DataMarts = Model.List,
    HiddenFieldName = "SelectedDataMarts",
    AllDataMartIdsExpression = "allDataMarts",
    ReloadUrl = Url.Action<RequestController>( c => c.DataMartsListBody( Model.List.ModelForReload() ) ),
    Suffix = item => new System.Web.WebPages.HelperResult(__razor_template_writer => {

            
            #line default
            #line hidden
WriteLiteralTo(__razor_template_writer, "<div>\r\n");

            
            #line 13 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
           var m = Model.List.ModelForReload(); 
            
            #line default
            #line hidden
WriteLiteralTo(__razor_template_writer, "\r\n");

            
            #line 14 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
         foreach( var p in Model.ProjectIDs.EmptyIfNull() ) {
            m.ProjectID = p;

            
            #line default
            #line hidden
WriteLiteralTo(__razor_template_writer, "            <a");

WriteAttributeTo(__razor_template_writer, "href", Tuple.Create(" href=\"", 605), Tuple.Create("\"", 676)
            
            #line 16 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
, Tuple.Create(Tuple.Create("", 612), Tuple.Create<System.Object, System.Int32>(Url.Action( (RequestController c) => c.DataMartsListBody( m ) )
            
            #line default
            #line hidden
, 612), false)
);

WriteAttributeTo(__razor_template_writer, "class", Tuple.Create(" class=\"", 677), Tuple.Create("\"", 711)
, Tuple.Create(Tuple.Create("", 685), Tuple.Create("GridReloadLink", 685), true)
, Tuple.Create(Tuple.Create(" ", 699), Tuple.Create("Project", 700), true)
            
            #line 16 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
                                      , Tuple.Create(Tuple.Create("", 707), Tuple.Create<System.Object, System.Int32>(p
            
            #line default
            #line hidden
, 707), false)
);

WriteLiteralTo(__razor_template_writer, " style=\"display: none\"");

WriteLiteralTo(__razor_template_writer, ">_</a> \r\n");

            
            #line 17 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteralTo(__razor_template_writer, "    </div>\r\n");

            
            #line 19 "..\..\Views\Request\RequestDataMartsListBody.cshtml"
})} ));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591