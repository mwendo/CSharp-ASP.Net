#pragma checksum "C:\Users\wendo\Desktop\CodingDojo\CSharp\ASP.NET\ViewModelFun\Views\Home\Names.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b618a9b4e4026a5b1af2841e829fd2a8e74a3b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Names), @"mvc.1.0.view", @"/Views/Home/Names.cshtml")]
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
#line 1 "C:\Users\wendo\Desktop\CodingDojo\CSharp\ASP.NET\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wendo\Desktop\CodingDojo\CSharp\ASP.NET\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b618a9b4e4026a5b1af2841e829fd2a8e74a3b47", @"/Views/Home/Names.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Names : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Here are some names!</h2>\r\n");
#nullable restore
#line 3 "C:\Users\wendo\Desktop\CodingDojo\CSharp\ASP.NET\ViewModelFun\Views\Home\Names.cshtml"
 foreach(var name in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "C:\Users\wendo\Desktop\CodingDojo\CSharp\ASP.NET\ViewModelFun\Views\Home\Names.cshtml"
  Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "C:\Users\wendo\Desktop\CodingDojo\CSharp\ASP.NET\ViewModelFun\Views\Home\Names.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
