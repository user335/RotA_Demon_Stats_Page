#pragma checksum "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc97b48d96e0953718880ca985f68c3e90b69712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RotADemonStatsPage.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(RotADemonStatsPage.Pages.Pages_Index), null)]
namespace RotADemonStatsPage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\_ViewImports.cshtml"
using RotADemonStatsPage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc97b48d96e0953718880ca985f68c3e90b69712", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5480562115a01443ef8f172e9321e1ae7a589cce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(96, 1559, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-10"">
        <asp:GridView id=""grdPivot"" runat=""server"" AutoGenerateColumns=""True"">
        </asp:GridView>
        <asp:SqlDataSource ID=""SqlDataSource1"" runat=""server"" ConnectionString=""<%$ ConnectionStrings:MySql %>"" ProviderName=""<%$ ConnectionStrings:MySql.ProviderName %>"" SelectCommand=""SELECT * FROM resources""></asp:SqlDataSource>
        <h2>Demon Stats</h2>
        <h4>
            Loading stats from Demon Stats Database in sql server:
        </h4>        
    </div>
</div>
<table class=""table"">
    <thead>
        <tr>
            <th>DemonStats</th>
            <th>Max HP</th>
            <th>Grab Range</th>
            <th>Preferred Attack Range</th>
            <th>Move Speed</th>
            <th>Acceleration</th>
            <th>Deceleration</th>
            <th>Aggro Radius</th>
            <th>Patrol Range</th>
            <th>Patrol Rate Min</th>
            <th>Patrol Rate Max</th>
            <th>Hunger Reduced Per Meat<");
            WriteLiteral(@"/th>
            <th>Base Fearsomeness</th>
            <th>Fearsomeness When Attacking</th>
            <th>Standing Height</th>
            <th>Sleeping Height</th>
            <th>Can Use Weapons?</th>
            <th>Loves To Chase?</th>
            <th>Starting Happiness</th>
            <th>Fallback Threshhold</th>
            <th>Basic Attack Damage</th>
            <th>Building Attack Damage</th>
            <th>AOE Damage</th>
            <th>Elemental Affinity</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 49 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
         foreach (var demon in Model.demonStats)
        {

#line default
#line hidden
            BeginContext(1716, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1747, 15, false);
#line 52 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.demonName);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1786, 11, false);
#line 53 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.maxHp);

#line default
#line hidden
            EndContext();
            BeginContext(1797, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1821, 15, false);
#line 54 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.grabRange);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1860, 26, false);
#line 55 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.preferredAttackRange);

#line default
#line hidden
            EndContext();
            BeginContext(1886, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1910, 15, false);
#line 56 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.moveSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(1925, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1949, 18, false);
#line 57 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.acceleration);

#line default
#line hidden
            EndContext();
            BeginContext(1967, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1991, 18, false);
#line 58 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.deceleration);

#line default
#line hidden
            EndContext();
            BeginContext(2009, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2033, 17, false);
#line 59 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.aggroRadius);

#line default
#line hidden
            EndContext();
            BeginContext(2050, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2074, 17, false);
#line 60 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.patrolRange);

#line default
#line hidden
            EndContext();
            BeginContext(2091, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2115, 19, false);
#line 61 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.patrolRateMin);

#line default
#line hidden
            EndContext();
            BeginContext(2134, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2158, 19, false);
#line 62 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.patrolRateMax);

#line default
#line hidden
            EndContext();
            BeginContext(2177, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2201, 26, false);
#line 63 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.hungerReducedPerMeat);

#line default
#line hidden
            EndContext();
            BeginContext(2227, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2251, 22, false);
#line 64 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.baseFearsomeness);

#line default
#line hidden
            EndContext();
            BeginContext(2273, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2297, 31, false);
#line 65 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.fearsomenessWhenAttacking);

#line default
#line hidden
            EndContext();
            BeginContext(2328, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2352, 20, false);
#line 66 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.standingHeight);

#line default
#line hidden
            EndContext();
            BeginContext(2372, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2396, 20, false);
#line 67 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.sleepingHeight);

#line default
#line hidden
            EndContext();
            BeginContext(2416, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2440, 19, false);
#line 68 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.canUseWeapons);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2483, 18, false);
#line 69 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.lovesToChase);

#line default
#line hidden
            EndContext();
            BeginContext(2501, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2525, 23, false);
#line 70 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.startingHappiness);

#line default
#line hidden
            EndContext();
            BeginContext(2548, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2572, 24, false);
#line 71 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.fallbackThreshhold);

#line default
#line hidden
            EndContext();
            BeginContext(2596, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2620, 23, false);
#line 72 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.basicAttackDamage);

#line default
#line hidden
            EndContext();
            BeginContext(2643, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2667, 26, false);
#line 73 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.buildingAttackDamage);

#line default
#line hidden
            EndContext();
            BeginContext(2693, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2717, 15, false);
#line 74 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.aoeDamage);

#line default
#line hidden
            EndContext();
            BeginContext(2732, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2756, 23, false);
#line 75 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
           Write(demon.elementalAffinity);

#line default
#line hidden
            EndContext();
            BeginContext(2779, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Rob Clark\Desktop\game folder\DemonsStatsPage\RotA-Demons-Stats\RotADemonStatsPage\RotADemonStatsPage\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2812, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RotADemonStatsPage.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RotADemonStatsPage.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RotADemonStatsPage.Pages.IndexModel>)PageContext?.ViewData;
        public RotADemonStatsPage.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
