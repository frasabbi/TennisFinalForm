#pragma checksum "C:\Users\frasa\source\repos\TennisFormFinal-master\TennisFormFinal-master\TennisFormFinal\Views\Shared\ReservationSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feae5db56e7a9c463f130fcd5695526d0b6d8062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ReservationSummary), @"mvc.1.0.view", @"/Views/Shared/ReservationSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ReservationSummary.cshtml", typeof(AspNetCore.Views_Shared_ReservationSummary))]
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
#line 1 "C:\Users\frasa\source\repos\TennisFormFinal-master\TennisFormFinal-master\TennisFormFinal\Views\_ViewImports.cshtml"
using TennisFormFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feae5db56e7a9c463f130fcd5695526d0b6d8062", @"/Views/Shared/ReservationSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03fabf74874704c8882eb5efa01bab4c36e7e2aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ReservationSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TennisFormFinal.Models.TennisReservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 22, true);
            WriteLiteral("<tr>\n    <td>\n        ");
            EndContext();
            BeginContext(72, 45, false);
#line 4 "C:\Users\frasa\source\repos\TennisFormFinal-master\TennisFormFinal-master\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.FieldName));

#line default
#line hidden
            EndContext();
            BeginContext(117, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(146, 51, false);
#line 7 "C:\Users\frasa\source\repos\TennisFormFinal-master\TennisFormFinal-master\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.ReservationTime));

#line default
#line hidden
            EndContext();
            BeginContext(197, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(226, 45, false);
#line 10 "C:\Users\frasa\source\repos\TennisFormFinal-master\TennisFormFinal-master\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.MatchType));

#line default
#line hidden
            EndContext();
            BeginContext(271, 30, true);
            WriteLiteral("\n    </td>\n    <td>  \n        ");
            EndContext();
            BeginContext(301, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cd77450231489ca47fa080b9190eca", async() => {
                BeginContext(360, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\frasa\source\repos\TennisFormFinal-master\TennisFormFinal-master\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
                                 WriteLiteral(Model.ReservationId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 17, true);
            WriteLiteral("\n    </td>\n</tr>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TennisFormFinal.Models.TennisReservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
