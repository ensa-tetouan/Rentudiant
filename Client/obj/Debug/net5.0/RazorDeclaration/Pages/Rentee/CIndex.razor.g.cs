// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client2.Pages.Rentee
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Client")]
    public partial class CIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Projects\JEE-Exam\Rentudiant\Client\Pages\Rentee\CIndex.razor"
       
    [Parameter] public AnnouncementT[] Announcements { get; set; } = Enumerable.Range(0,10).Select(i => TypeEnhancements.getRandomeAnn()).ToArray();
    [Parameter] public ReservationT[] Reservations { get; set; } = Enumerable.Range(0,10).Select(i => TypeEnhancements.getRandomRes()).ToArray();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
