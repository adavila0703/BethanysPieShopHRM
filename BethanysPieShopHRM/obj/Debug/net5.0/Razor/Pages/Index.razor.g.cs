#pragma checksum "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1e6570d0dca624c13f526c69aeb530c64e9110"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\n\r\nExample of one way, two way, and two way on even model binding\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1 class=\"page-title\">Welcom to Bethany\'s Pie Shop HRM!</h1>\r\n<br>\r\n");
            __builder.AddMarkupContent(2, "<h3>Using this application, you can manage your wonderful staff working for us all over the world.</h3>\r\n\r\n\r\n");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 12 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor"
                           Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 13 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor"
                           Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor"
                           Employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.FirstName = __value, Employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor"
                           Employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.LastName = __value, Employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor"
                                 Employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.FirstName = __value, Employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\Index.razor"
                                 Employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.LastName = __value, Employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
