#pragma checksum "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27c30ce22ff1873705acb3323177be0645b908e2"
// <auto-generated/>
#pragma warning disable 1591
namespace Client2.Pages.Authentification
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
#nullable restore
#line 1 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "max-width: 400px;");
            __builder.OpenComponent<MudBlazor.MudCard>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudForm>(6);
                    __builder3.AddAttribute(7, "IsValid", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                                 success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "IsValidChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                    __builder3.AddAttribute(9, "Errors", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                                                         errors

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "ErrorsChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => errors = __value, errors))));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(12);
                        __builder4.AddAttribute(13, "Label", "Email");
                        __builder4.AddAttribute(14, "Required", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "RequiredError", "Email is required!");
                        __builder4.AddAttribute(16, "Validation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                            new EmailAddressAttribute() {ErrorMessage = "The email address is invalid"}

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 9 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                           user.email

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.email = __value, user.email))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(19, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(20);
                        __builder4.AddAttribute(21, "Label", "Password");
                        __builder4.AddAttribute(22, "HelperText", "Choose a strong password");
                        __builder4.AddAttribute(23, "InputType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.InputType>(
#nullable restore
#line 12 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                         InputType.Password

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "RequiredError", "Password is required!");
                        __builder4.AddComponentReferenceCapture(25, (__value) => {
#nullable restore
#line 11 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                                                                                      pwField1 = (MudBlazor.MudTextField<string>)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 8 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                           form = (MudBlazor.MudForm)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(28);
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(30);
                    __builder3.AddAttribute(31, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                                       Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Disabled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                                                                  !success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Class", "ml-auto");
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(36, "Login");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n    \r\n    ");
            __builder.OpenComponent<MudBlazor.MudExpansionPanels>(38);
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudExpansionPanel>(40);
                __builder2.AddAttribute(41, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                   $"Show Errors ({errors.Length})"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
             foreach (var error in errors)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(43);
                    __builder3.AddAttribute(44, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
                                 Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 25 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
__builder4.AddContent(46, error);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 26 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Authentification\Login.razor"
       
    private CredentialsT user {get; set;} = new CredentialsT {};
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
