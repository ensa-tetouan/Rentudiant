#pragma checksum "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c86dfa9c6641ac24624fb32166aaeedab61265f"
// <auto-generated/>
#pragma warning disable 1591
namespace Client2.Pages.Renter
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Pages.Authentification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Pages.Rentee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Pages.Renter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projects\JEE-Exam\Rentudiant\Client\_Imports.razor"
using Client2.Pages.Shared.Componants;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin")]
    public partial class RIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudTabs>(0);
            __builder.AddAttribute(1, "Outlined", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Position", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Position>(
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                                   Position.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Rounded", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Border", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ApplyEffectsToContainer", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(7);
                __builder2.AddAttribute(8, "Text", "Dashboard");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Client2.Pages.Renter.Overview>(10);
                    __builder3.AddAttribute(11, "Reservations", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Client2.Models.ReservationT[]>(
#nullable restore
#line 5 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                                Reservations

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Announcements", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Client2.Models.AnnouncementT[]>(
#nullable restore
#line 5 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
                                                             Announcements

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(14);
                __builder2.AddAttribute(15, "Text", "Add Announcement");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Client2.Pages.Renter.AnnoucementForm>(17);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Renter\RIndex.razor"
       
    [Parameter] public AnnouncementT[] Announcements { get; set; } = Enumerable.Range(0,10).Select(i => TypeEnhancements.getRandomeAnn()).ToArray();
    [Parameter] public ReservationT[] Reservations { get; set; } = Enumerable.Range(0,10).Select(i => TypeEnhancements.getRandomRes()).ToArray();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
