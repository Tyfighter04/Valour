#pragma checksum "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "502852f4bdb268d1bb83aed059459edcda3eb978"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Valour.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Valour.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\_Imports.razor"
using Valour.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\SpikeViper\source\repos\Valour\Valour\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
