#pragma checksum "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38ad49376bd04de4cd72fe2661c8bad577343cd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{EmployeeId}")]
    public partial class EmployeeDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Details for ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                    Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12 row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-2");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 8 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Employee.EmployeeId}.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-10 row");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-xs-12 col-sm-8");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group row");
            __builder.AddMarkupContent(21, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-8");
            __builder.OpenElement(24, "label");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control-plaintext");
            __builder.AddContent(27, 
#nullable restore
#line 15 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group row");
            __builder.AddMarkupContent(31, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-8");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "readonly");
            __builder.AddAttribute(37, "class", "form-control-plaintext");
            __builder.AddContent(38, 
#nullable restore
#line 21 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                                Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group row");
            __builder.AddMarkupContent(42, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-8");
            __builder.OpenElement(45, "label");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "readonly");
            __builder.AddAttribute(48, "class", "form-control-plaintext");
            __builder.AddContent(49, 
#nullable restore
#line 28 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group row");
            __builder.AddMarkupContent(53, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-sm-8");
            __builder.OpenElement(56, "label");
            __builder.AddAttribute(57, "type", "text");
            __builder.AddAttribute(58, "readonly");
            __builder.AddAttribute(59, "class", "form-control-plaintext");
            __builder.AddContent(60, 
#nullable restore
#line 38 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group row");
            __builder.AddMarkupContent(64, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-sm-8");
            __builder.OpenElement(67, "label");
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "readonly");
            __builder.AddAttribute(70, "class", "form-control-plaintext");
            __builder.AddContent(71, 
#nullable restore
#line 45 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group row");
            __builder.AddMarkupContent(75, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-sm-8");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "readonly");
            __builder.AddAttribute(81, "class", "form-control-plaintext");
            __builder.AddContent(82, 
#nullable restore
#line 52 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "form-group row");
            __builder.AddMarkupContent(86, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n    ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-sm-8");
            __builder.OpenElement(89, "label");
            __builder.AddAttribute(90, "type", "text");
            __builder.AddAttribute(91, "readonly");
            __builder.AddAttribute(92, "class", "form-control-plaintext");
            __builder.AddContent(93, 
#nullable restore
#line 59 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "form-group row");
            __builder.AddMarkupContent(97, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-sm-8");
            __builder.OpenElement(100, "label");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "readonly");
            __builder.AddAttribute(103, "class", "form-control-plaintext");
            __builder.AddContent(104, 
#nullable restore
#line 66 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-group row");
            __builder.AddMarkupContent(108, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n    ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "col-sm-8");
            __builder.OpenElement(111, "label");
            __builder.AddAttribute(112, "type", "text");
            __builder.AddAttribute(113, "readonly");
            __builder.AddAttribute(114, "class", "form-control-plaintext");
            __builder.AddContent(115, 
#nullable restore
#line 73 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "form-group row");
            __builder.AddMarkupContent(119, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "col-sm-8");
            __builder.OpenElement(122, "label");
            __builder.AddAttribute(123, "type", "text");
            __builder.AddAttribute(124, "readonly");
            __builder.AddAttribute(125, "class", "form-control-plaintext");
            __builder.AddContent(126, 
#nullable restore
#line 80 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "form-group row");
            __builder.AddMarkupContent(130, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n    ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "col-sm-8");
#nullable restore
#line 88 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
         if (Employee.Smoker)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(133, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>");
#nullable restore
#line 91 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(134, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>");
#nullable restore
#line 95 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "form-group row");
            __builder.AddMarkupContent(138, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n    ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "col-sm-8");
            __builder.OpenElement(141, "label");
            __builder.AddAttribute(142, "type", "text");
            __builder.AddAttribute(143, "readonly");
            __builder.AddAttribute(144, "class", "form-control-plaintext");
            __builder.AddContent(145, 
#nullable restore
#line 103 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n\r\n");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "form-group row");
            __builder.AddMarkupContent(149, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n    ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "col-sm-8");
            __builder.OpenElement(152, "label");
            __builder.AddAttribute(153, "type", "text");
            __builder.AddAttribute(154, "readonly");
            __builder.AddAttribute(155, "class", "form-control-plaintext");
            __builder.AddContent(156, 
#nullable restore
#line 110 "C:\Users\adavila\Documents\GitHub\BethanysPieShopHRM-private\BethanysPieShopHRM\Pages\EmployeeDetails.razor"
                                                                    Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
