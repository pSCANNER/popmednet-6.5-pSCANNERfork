﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.General.CriteriaGroup.Views.CriteriaGroup {
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
    using Lpp.Dns.General.CriteriaGroup;
    using Lpp.Dns.General.CriteriaGroup.Models;
    
    
    public partial class CriteriaGroup : System.Web.Mvc.WebViewPage<Lpp.Dns.General.CriteriaGroup.Models.CriteriaGroupModel> {
        
#line hidden

#line hidden
public System.Web.WebPages.HelperResult DisplayTerms(IEnumerable<TermSelectionModel> terms)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 104 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
 

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <ul style=\"z-index: 1000000;\" class=\"TermSubmenu\">\r\n");



#line 106 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
         foreach (TermSelectionModel term in terms)
        {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            <li style=\"width: 150px;\"><a href=\"#\"><span class=\"TermMenuItem\"><spa" +
"n class=\"");



#line 108 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                           WriteTo(@__razor_helper_writer, term.Name);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 108 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                       WriteTo(@__razor_helper_writer, term.Label);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span></span></a>\r\n");



#line 109 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                 if (!term.Terms.NullOrEmpty())
                {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "                    ");



#line 111 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
WriteTo(@__razor_helper_writer, DisplayTerms(term.Terms));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\r\n");



#line 112 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                }

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            </li>\r\n");



#line 114 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
        }

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    </ul>\r\n");



#line 116 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"

#line default
#line hidden

});

}


        
        public CriteriaGroup() {
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {


            
            #line 2 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
   this.Stylesheet("CriteriaGroup.min.css"); 

            
            #line default
            #line hidden

            
            #line 3 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
WriteLiteral("\r\n<div id=\"");

            
            #line default
            #line hidden

WriteLiteral("cg");


            
            #line 4 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                          
            
            #line default
            #line hidden

            
            #line 4 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                      Write(Model.CriteriaGroupId);

            
            #line default
            #line hidden

            
            #line 4 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                 WriteLiteral("\" class=\"CriteriaGroup\" ");

            
            #line default
            #line hidden
            
            #line 4 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                            if (Model.Hidden)
                                                                            {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("style=\"display: none;\"");

WriteLiteral(" ");


            
            #line 5 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                                                                  }
            
            #line default
            #line hidden

            
            #line 5 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                                                                    WriteLiteral(">\r\n\r\n    <div id=\"DivCriteriaGroupAnd\" style=\"text-align: center; font-weight: bo" +
"ld; ");

            
            #line default
            #line hidden
            
            #line 7 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                                 if(Model.CriteriaGroupId <= 1) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("display: none;");


            
            #line 7 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                                                                                             }
            
            #line default
            #line hidden
WriteLiteral("\">AND</div>\r\n    <div ");


            
            #line 8 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
    Write(Html.Section(title: Model.CriteriaGroupName.NullOrEmpty() ? "Criteria Group" : "Criteria Group: " + Model.CriteriaGroupName, settingsKey: "CriteriaGroup", buttonsBindings: "ui-button-remove: removeCriteriaGroup(event)"));

            
            #line default
            #line hidden
WriteLiteral(">\r\n        <div class=\"CriteriaGroupHeader\">\r\n\r\n            <div class=\"ui-form\">" +
"\r\n                <div>\r\n                    ");


            
            #line 13 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
               Write(Html.Label("Group Name"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            ");


            
            #line 16 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
       Write(Html.TextBoxFor(m => m.CriteriaGroupName, new { id = "CriteriaGroupName_" + Model.CriteriaGroupId, @class = "CriteriaGroupName" }));

            
            #line default
            #line hidden
WriteLiteral(@"
            <a href=""#"" onclick=""return showCGInfo(this);"" style=""margin-left: 15px;"">About this Criteria Group...</a>
            <ul id=""Terms"" class=""Terms"" style=""float: right; width: 150px;"">
                <li><a href=""#""><span class=""TermMenuItem""><span class=""");


            
            #line 19 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                   Write(Model.TermSelections.Name);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 19 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                                               Write(Model.TermSelections.Label);

            
            #line default
            #line hidden
WriteLiteral("</span></span></a>\r\n                    ");


            
            #line 20 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
               Write(DisplayTerms(Model.TermSelections.Terms));

            
            #line default
            #line hidden

            
            #line 20 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                             WriteLiteral(@"
                </li>
            </ul>
        </div>
    <hr />
    <div class=""InputParameters"">
    </div>
    <fieldset class=""OrInputParameters"" style=""display: none; border: solid 1px gray;"">
        <legend style=""display: block; text-align: center;"">OR</legend>
    </fieldset>
    <fieldset class=""AddInputParameters"" style=""display: none; border: solid 1px gray;"">
        <legend style=""display: block; text-align: center;"">AND</legend>
    </fieldset>
    <hr />
    <div class=""CriteriaGroupFooter"">
        <table>
            <tr>
                <td style=""vertical-align: top"">
                    <div class=""CriteriaGroupOptions"" style=""margin: 0px;"">
                        <div id=""");

            
            #line default
            #line hidden

WriteLiteral("ExcludeCriteriaGroup_");


            
            #line 39 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                     
            
            #line default
            #line hidden

            
            #line 39 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                 Write(Model.CriteriaGroupId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 40 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                       Write(Html.CheckBoxFor(m => m.ExcludeCriteriaGroup, new { @class = "ExcludeCriteriaGroup" }));

            
            #line default
            #line hidden
WriteLiteral(" Exclude Criteria Group\r\n                        </div>\r\n                        " +
"");




            
            #line 42 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                                            WriteLiteral("\r\n                        <div id=\"");

            
            #line default
            #line hidden

WriteLiteral("SaveCriteriaGroup_");


            
            #line 43 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                                  
            
            #line default
            #line hidden

            
            #line 43 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                                                              Write(Model.CriteriaGroupId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 44 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                       Write(Html.CheckBoxFor(m => m.SaveCriteriaGroup, new { @class = "SaveCriteriaGroup", style = "visibility:hidden;" }));

            
            #line default
            #line hidden
WriteLiteral(" ");



WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </t" +
"d>\r\n                <td style=\"vertical-align: top\">\r\n                    <div c" +
"lass=\"CriteriaGroupObservationPeriod\">\r\n");


            
            #line 50 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                          
                            TermModel tm = !Model.Terms.NullOrEmpty() ? Model.Terms.Where(t => t.TermName == "ObservationPeriod").FirstOrDefault() : null;
                        

            
            #line default
            #line hidden
WriteLiteral("                        ");


            
            #line 53 "D:\Lincoln Peak\PMN\Dns\Plugins\Lpp.Dns.General.CriteriaGroup\Views\CriteriaGroup\CriteriaGroup.cshtml"
                    Write(Html.Partial<Lpp.Dns.General.CriteriaGroup.Views.CriteriaGroup.Terms.ObservationPeriod>().WithModel(
                                    new ObservationPeriodModel
                                    {
                                        StartPeriod = tm != null && !string.IsNullOrEmpty(tm.Args["StartPeriod"]) ? DateTime.Parse(tm.Args["StartPeriod"]) : (DateTime?)null,
                                        EndPeriod = tm != null && !string.IsNullOrEmpty(tm.Args["EndPeriod"]) ? DateTime.Parse(tm.Args["EndPeriod"]) : (DateTime?)null,
                                    }
                                )
                            );

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        <" +
"/table>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n<div id=\"PrimaryCGInfo\" style=\"display: n" +
"one;\">\r\n    This part of the query isolates the final result you are looking for" +
" (i.e. people with diabetes). Individuals matching the specified criteria in the" +
" primary group are \r\n    selected out of the other cohorts chosen in other Crite" +
"ria Groups. This is the only criteria group you are able to stratify. Without an" +
"y additional criteria groups, this \r\n    criteria groups acts identically to the" +
" original query builder.<br />\r\n    <br />\r\n    To begin defining a cohort more " +
"restricted than the entire patient database, press the \"+\" sign in the upper rig" +
"ht of the \"Criteria Groups\" box.\r\n</div>\r\n\r\n<div id=\"OtherCGInfo\" style=\"display" +
": none;\">\r\n    Each of these criteria groups reduce the patient base searched. F" +
"or example, adding the demographic term \"gender\" and selecting \"males\" will rest" +
"rict your results to \r\n    males only. This becomes more powerful when you are t" +
"rying to control for groupings of diseases, especially over certain periods of t" +
"ime. If you want your final results \r\n    to exclude this group, check \"Exclude " +
"Criteria group\" in the respective box.<br />\r\n    <br />\r\n    As with the origin" +
"al query builder, all selections within a box get an \"OR\" placed between each te" +
"rm.  For example, if you select both ILI and Asthma in the same box, \r\n    the q" +
"uery will look for those patients that match either of the criteria.<br />\r\n    " +
"<br />\r\n    What the query composer adds, is the ability to insert an \"AND\" into" +
" your query results. When you press the \"+\" in the upper right of the \"Criteria " +
"Groups\" box, everything \r\n    in the new query will be joined with an \"AND\" mean" +
"ing that all of the criteria you have defined in all of the criteria groups have" +
" to be matched for it to be considered \r\n    in the results, not all of them.<br" +
" />\r\n    <br />\r\n    Be sure to make use of date ranges to better define your co" +
"hort. A small date range in the primary criteria group and larger (or undefined)" +
" date ranges in the additional \r\n    criteria groups can help isolate new cases " +
"or areas of concern.\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    function sh" +
"owCGInfo(link) {\r\n        // display a help dialog for the criteria group depend" +
"ing on if it is primary or not\r\n        if ($(link).parents(\".CriteriaGroup\").at" +
"tr(\'id\') == \'cg1\')\r\n            return popup($(\'#PrimaryCGInfo\'), \'Information\')" +
";\r\n        else\r\n            return popup($(\'#OtherCGInfo\'), \'Information\');\r\n  " +
"  }\r\n</script>\r\n\r\n");




        }
    }
}