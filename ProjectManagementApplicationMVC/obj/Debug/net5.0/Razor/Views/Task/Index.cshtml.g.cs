#pragma checksum "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c85124263e475ef4ef0310034db71d1571e1cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\_ViewImports.cshtml"
using ProjectManagementApplicationMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\_ViewImports.cshtml"
using ProjectManagementApplicationMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c85124263e475ef4ef0310034db71d1571e1cf5", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21370356de881c6123155227eaa69a45716deb0f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectManagementApplicationMVC.Models.ViewModels.TaskVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Task", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
 if (User.IsInRole(ProjectManagementApplicationMVC.Helper.Helper.Admin))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container p-3"">
        <div class=""col"">
            <div class=""container"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""text text-black-50>List of Tasks</a>
                    <li />
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c85124263e475ef4ef0310034db71d1571e1cf56244", async() => {
                WriteLiteral("Create new Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <br />\r\n");
#nullable restore
#line 20 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-striped"" style="" width: 100%"">
                <thead>
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Description
                        </th>
                        <th>
                            Project
                        </th>
                        <th>
                            Manager
                        </th>
                        <th>
                            Status
                        </th>
                        <th>
                            Progress
                        </th>
                        <th>
                            Developer
                        </th>
                        <th>
                            Deadline
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 52 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"10%\">");
#nullable restore
#line 55 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 56 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 57 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 58 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.ManagerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 59 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 60 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % </td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 61 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.DeveloperName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 62 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.due);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                        <td width=\"30%\">\r\n                            <div class=\"col-6 text-right role=\"group\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c85124263e475ef4ef0310034db71d1571e1cf512254", async() => {
                WriteLiteral(" Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c85124263e475ef4ef0310034db71d1571e1cf514794", async() => {
                WriteLiteral(" Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 78 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 81 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
 if (User.IsInRole(ProjectManagementApplicationMVC.Helper.Helper.Developer))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container p-3"">
        <div class=""col"">
            <div class=""container"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""text text-black-50>List of Tasks</a>
                    <li />
                    <li class=""nav-item"">
                    </li>
                </ul>
            </div>
        </div>

        <br />
");
#nullable restore
#line 98 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-striped"" style="" width: 100%"">
                <thead>
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Description
                        </th>
                        <th>
                            Manager
                        </th>
                        <th>
                            Status
                        </th>
                        <th>
                            Progress
                        </th>
                        <th>
                            Developer
                        </th>
                        <th>
                            Deadline
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 127 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                         if (item.IsDeveloperAssigned == false || item.DeveloperName == User.Identity.Name)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td width=\"10%\">");
#nullable restore
#line 132 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"15%\">");
#nullable restore
#line 133 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"15%\">");
#nullable restore
#line 134 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.ManagerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"15%\">");
#nullable restore
#line 135 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"15%\">");
#nullable restore
#line 136 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % </td>\r\n                                <td width=\"15%\">");
#nullable restore
#line 137 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.DeveloperName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"15%\">");
#nullable restore
#line 138 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                           Write(item.due);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n\r\n\r\n                                <td width=\"30%\">\r\n                                    <div class=\"col-6 text-right role=\"group\">\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c85124263e475ef4ef0310034db71d1571e1cf523417", async() => {
                WriteLiteral(" Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 148 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 153 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 156 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
 if (User.IsInRole(ProjectManagementApplicationMVC.Helper.Helper.ProjectManager))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container p-3"">
        <div class=""col"">
            <div class=""container"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""text text-black-50>List of Tasks</a>
                    <li />
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c85124263e475ef4ef0310034db71d1571e1cf527736", async() => {
                WriteLiteral("Create new Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <br />\r\n");
#nullable restore
#line 175 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-striped"" style="" width: 100%"">
                <thead>
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Description
                        </th>
                        <th>
                            Project
                        </th>
                        <th>
                            Manager
                        </th>
                        <th>
                            Status
                        </th>
                        <th>
                            Progress
                        </th>
                        <th>
                            Developer
                        </th>
                        <th>
                            Deadline
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 207 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"10%\">");
#nullable restore
#line 210 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 211 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 212 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 213 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.ManagerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"14%\">");
#nullable restore
#line 214 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"8%\">");
#nullable restore
#line 215 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                  Write(item.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % </td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 216 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.DeveloperName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"15%\">");
#nullable restore
#line 217 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                   Write(item.due);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n\r\n\r\n                        <td width=\"30%\">\r\n                            <div class=\"col-6 text-right role=\"group\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c85124263e475ef4ef0310034db71d1571e1cf533752", async() => {
                WriteLiteral(" Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 223 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 227 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 231 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 234 "C:\Users\urost\Documents\GitHub\ProjectManagementSystem\ProjectManagementApplicationMVC\Views\Task\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectManagementApplicationMVC.Models.ViewModels.TaskVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
