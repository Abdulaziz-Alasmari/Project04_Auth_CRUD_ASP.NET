#pragma checksum "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd9d85da6f5772153d5ffdcfadfe534d475b4d4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feeds_Details), @"mvc.1.0.view", @"/Views/Feeds/Details.cshtml")]
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
#line 1 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/_ViewImports.cshtml"
using mininet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/_ViewImports.cshtml"
using mininet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9d85da6f5772153d5ffdcfadfe534d475b4d4c", @"/Views/Feeds/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0178981e085526ccb4429ed5b32a45218f318ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Feeds_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
  
    var feedItems = (ICollection<RssItemDTO>)ViewData["feedItems"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 6 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
 foreach (var item in feedItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <article class=\" my-5 \">\n    <h4> ");
#nullable restore
#line 9 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n    <p class=\'hdesc\' hidden> ");
#nullable restore
#line 10 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p class=\'desc\'></p>\n");
#nullable restore
#line 12 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
     if (item.Link != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 292, "\"", 309, 1);
#nullable restore
#line 14 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
WriteAttributeValue("", 299, item.Link, 299, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 14 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
                             Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n");
#nullable restore
#line 15 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </article>\n");
#nullable restore
#line 17 "/home/z/tuwaiq/dotnet/mvc/MiniNet/mininet/Views/Feeds/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    window.onload = function () {
        var hiddenDescs = document.querySelectorAll('.hdesc');
        var descs = document.querySelectorAll('.desc');
        console.log(hiddenDescs, descs);
        hiddenDescs.forEach((hdesc, index) => {
            var parser = new DOMParser()
            var doc = parser.parseFromString(hdesc.innerHTML, 'text/html')
            descs[index].innerHTML = doc.documentElement.innerText
        })
    }
</script>");
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
