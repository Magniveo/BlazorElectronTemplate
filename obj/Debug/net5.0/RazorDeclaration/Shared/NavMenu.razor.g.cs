// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorElectronTemplate.Shared
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
#nullable restore
#line 28 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\NavMenu.razor"
using Components;

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
#line 29 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\NavMenu.razor"
       
    List<TabClass> Listnavlink;
    private bool collapseNavMenu = true;
    private TabClass fetchdata = new TabClass { Href="fetchdata",Icon="list-rich",Name="Fetch data" };
    private TabClass counter = new TabClass { Href = "counter", Icon = "plus", Name = "Counter" };
    private TabClass home = new TabClass { Href = "", Icon = "home", Name = "Home" };

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private void AddCommponents(TabClass str)
    {
        if(!Listnavlink.Contains(str))
            //    Listnavlink.Remove(str);
            Listnavlink.Add(str);
    }
    public void SetListNavlink(List<TabClass> listnavlink)
    {
        Listnavlink = listnavlink;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591