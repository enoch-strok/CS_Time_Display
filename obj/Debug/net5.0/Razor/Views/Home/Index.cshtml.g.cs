#pragma checksum "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22ef1c27fb0a26a9a2fbaf9a600a280a996addf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/_ViewImports.cshtml"
using CS_Time_Display_B;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/_ViewImports.cshtml"
using CS_Time_Display_B.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ef1c27fb0a26a9a2fbaf9a600a280a996addf1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5bafa0b1672b8451dbe88830ad1869a64cbf74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <h5 class=\"display-4\">The current time and date:</h1>\r\n");
#nullable restore
#line 8 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/Home/Index.cshtml"
  DateTime CurrentTime = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 9 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/Home/Index.cshtml"
   Write(CurrentTime.ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 10 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_Time_Display_B/Views/Home/Index.cshtml"
   Write(CurrentTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
