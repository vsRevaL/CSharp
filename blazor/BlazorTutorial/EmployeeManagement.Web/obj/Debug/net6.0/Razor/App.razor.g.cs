#pragma checksum "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b995d8983425f62913cbc36277ef5379c0567c"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\App.razor"
                      typeof(App).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(3);
                __builder2.AddAttribute(4, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.FocusOnNavigate>(7);
                __builder2.AddAttribute(8, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\App.razor"
                                     routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Selector", "h1");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Not found");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(15);
                __builder2.AddAttribute(16, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "D:\MyGitHub\c-sharp\blazor\BlazorTutorial\EmployeeManagement.Web\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<p role=\"alert\">Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
