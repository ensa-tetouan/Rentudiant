#pragma checksum "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73318a3edd393c895650c9e9eb1674d857e8a2d4"
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
    public partial class Announcement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(2);
                __builder2.AddAttribute(3, "CardHeaderAvatar", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudAvatar>(4);
                    __builder3.AddAttribute(5, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 4 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                              Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 4 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
__builder4.AddContent(7, Index);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(8, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(9);
                    __builder3.AddAttribute(10, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                           Typo.body1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 7 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
__builder4.AddContent(12, Data?.price);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(13, " ?? 0");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudText>(15);
                    __builder3.AddAttribute(16, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                           Typo.body2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
__builder4.AddContent(18, Data?.house?.address?.toString);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(19, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(20);
                    __builder3.AddAttribute(21, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                  Icons.Material.Filled.Settings

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                                                         Color.Default

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 14 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
     if((Data?.house?.pictures?.Length ?? 0) > 0){

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudCardMedia>(23);
                __builder2.AddAttribute(24, "Image", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                              Data?.house?.pictures[0].data

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Height", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                                                     250

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 16 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
    } else {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudCardMedia>(26);
                __builder2.AddAttribute(27, "Image", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                              Icons.Material.Filled.Photo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Height", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                                                   250

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 18 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudCardContent>(29);
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(31);
                    __builder3.AddAttribute(32, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 20 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                       Typo.body2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 20 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
__builder4.AddContent(34, Data?.house?.description);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(36);
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(38);
                    __builder3.AddAttribute(39, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                              Icons.Material.Filled.Share

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                                                  Color.Default

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "d-flex flex-column align-center");
                    __builder3.OpenComponent<MudBlazor.MudRating>(44);
                    __builder3.AddAttribute(45, "HoveredValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32?>(this, 
#nullable restore
#line 25 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                                                              HandleHoveredValueChanged

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(46, "SelectedValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
                                            selectedVal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "SelectedValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedVal = __value, selectedVal))));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Shared\Componants\Announcement.razor"
       
    [Parameter] public int Index {get; set;} = 0;
    [Parameter] public AnnouncementT Data {get; set;} = null;
    public ReviewT rate {get; set;} = null;
    private int selectedVal = 0;
    private int? activeVal;

    private void HandleHoveredValueChanged(int? val) => activeVal = val;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
