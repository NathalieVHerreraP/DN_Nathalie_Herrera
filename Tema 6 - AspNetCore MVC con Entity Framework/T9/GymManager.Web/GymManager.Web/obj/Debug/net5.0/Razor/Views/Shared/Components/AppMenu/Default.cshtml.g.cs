#pragma checksum "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 6 - AspNetCore MVC con Entity Framework\T9\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4337038643f7a5bc4c21b40a9036cb330e49d900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/Default.cshtml")]
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
#line 1 "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 6 - AspNetCore MVC con Entity Framework\T9\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\Default.cshtml"
using GymManager.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4337038643f7a5bc4c21b40a9036cb330e49d900", @"/Views/Shared/Components/AppMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AppMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Web.Models.MenuViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 6 - AspNetCore MVC con Entity Framework\T9\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\Default.cshtml"
  

    var orderMenuItems = Model.Menu.OrderBy(x => x.Order);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"navbar-nav me-auto mb-2 mb-md-0\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 6 - AspNetCore MVC con Entity Framework\T9\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\Default.cshtml"
     foreach (var menuItem in orderMenuItems)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 6 - AspNetCore MVC con Entity Framework\T9\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\Default.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml", new UserMenuItemViewModel 
        {
            MenuItem = menuItem,
            RootLevel = true,
            CurrentPageName = Model.CurrentPageName
        }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Nath\Documents\Academia .Net\DN_Nathalie_Herrera\Tema 6 - AspNetCore MVC con Entity Framework\T9\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\Default.cshtml"
          

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Web.Models.MenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
