#pragma checksum "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f8811ddb5eb9462318403bc6f1072d6a2c09fb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts__DonHangPartialView), @"mvc.1.0.view", @"/Views/Accounts/_DonHangPartialView.cshtml")]
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
#line 1 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8811ddb5eb9462318403bc6f1072d6a2c09fb2", @"/Views/Accounts/_DonHangPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts__DonHangPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OnlineMarket.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered table-hover"">
            <tbody>
                <tr>
                    <th>ID</th>
                    <th>Ngày mua hàng</th>
                    <th>Ngày chuyển hàng</th>
                    <th>Trạng thái đơn hàng</th>
                    <th>Tổng tiền</th>
                    <th></th>
                </tr>
");
#nullable restore
#line 16 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 19 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                                                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                       Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                        <td>\r\n                            <a href=\"javascript:void(0)\" class=\"btn btn-secondary btn-primary-hover\"><span>Xem đơn hàng</span></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Chưa có đơn hàng !</p>\r\n");
#nullable restore
#line 38 "C:\Users\DUY PHUONG\Downloads\OnlineMarket\Views\Accounts\_DonHangPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OnlineMarket.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
