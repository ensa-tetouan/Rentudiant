#pragma checksum "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b911a418fe5946ed4db7fe60b0251bbe3c2f7a3c"
// <auto-generated/>
#pragma warning disable 1591
namespace Client2.Pages.Shared.Componants
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
    public partial class Showcase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "Style", "height : 75vh; overflow-y:scroll;");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
     foreach(var announcement in Announcemets){

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudItem>(3);
                __builder2.AddAttribute(4, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
                             6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
                                    4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(8);
                    __builder3.AddAttribute(9, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
                                 2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Class", "pa-4");
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Client2.Pages.Shared.Componants.Announcement>(12);
                        __builder4.AddAttribute(13, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Client2.Models.AnnouncementT>(
#nullable restore
#line 5 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
                                    announcement

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "Index", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
                                                         0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Showcase.razor"
       
    [Parameter] public IEnumerable<AnnouncementT> Announcemets {get; set;} = Enumerable.Range(0,10).Select(_ => TypeEnhancements.getRandomeAnn()).ToArray();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
