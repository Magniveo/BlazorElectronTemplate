// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorElectronTemplate.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using BlazorElectronTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\_Imports.razor"
using BlazorElectronTemplate.Shared;

#line default
#line hidden
#nullable disable
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Components\Modal.razor"
       

    public bool RemvStation { get; set; }
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;

    public void Open()
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        StateHasChanged();
    }
    public void RemoveStation()
    {
        Close();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
