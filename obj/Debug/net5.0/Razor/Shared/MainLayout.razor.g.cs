#pragma checksum "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77201d8d18c0296bfaaa5654454f21b42d104772"
// <auto-generated/>
#pragma warning disable 1591
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
#line 55 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
using ElectronNET.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
using ElectronNET.API.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
using Components;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-vjg3tdneki");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "titlebar");
            __builder.AddAttribute(5, "class", "fixed-top");
            __builder.AddAttribute(6, "b-vjg3tdneki");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", "drag-region");
            __builder.AddAttribute(9, "b-vjg3tdneki");
            __builder.AddMarkupContent(10, "<div id=\"window-title\" b-vjg3tdneki><img class=\"icon\" srcset=\"icons/favicon.ico\" b-vjg3tdneki>\r\n                <span b-vjg3tdneki>Electron quick start</span></div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "window-controls");
            __builder.AddAttribute(13, "b-vjg3tdneki");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "button");
            __builder.AddAttribute(16, "id", "min-button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                              RestoreElectronApplication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-vjg3tdneki");
            __builder.AddMarkupContent(19, @"<img class=""icon"" srcset=""icons/min-w-10.png 1x, icons/min-w-12.png 1.25x, icons/min-w-15.png 1.5x, icons/min-w-15.png 1.75x, icons/min-w-20.png 2x, icons/min-w-20.png 2.25x, icons/min-w-24.png 2.5x, icons/min-w-30.png 3x, icons/min-w-30.png 3.5x"" draggable=""false"" b-vjg3tdneki>");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                 if (maximized)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                  RestorescreenApplication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "b-vjg3tdneki");
            __builder.AddMarkupContent(24, @"<img class=""icon"" srcset=""icons/restore-w-10.png 1x, icons/restore-w-12.png 1.25x, icons/restore-w-15.png 1.5x, icons/restore-w-15.png 1.75x, icons/restore-w-20.png 2x, icons/restore-w-20.png 2.25x, icons/restore-w-24.png 2.5x, icons/restore-w-30.png 3x, icons/restore-w-30.png 3.5x"" draggable=""false"" b-vjg3tdneki>");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                  FullscreenApplication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-vjg3tdneki");
            __builder.AddMarkupContent(29, @"<img class=""icon"" srcset=""icons/max-w-10.png 1x, icons/max-w-12.png 1.25x, icons/max-w-15.png 1.5x, icons/max-w-15.png 1.75x, icons/max-w-20.png 2x, icons/max-w-20.png 2.25x, icons/max-w-24.png 2.5x, icons/max-w-30.png 3x, icons/max-w-30.png 3.5x"" draggable=""false"" b-vjg3tdneki>");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "button");
            __builder.AddAttribute(32, "id", "close-button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                                CloseElectronApplication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "b-vjg3tdneki");
            __builder.AddMarkupContent(35, @"<img class=""icon"" srcset=""icons/close-w-10.png 1x, icons/close-w-12.png 1.25x, icons/close-w-15.png 1.5x, icons/close-w-15.png 1.75x, icons/close-w-20.png 2x, icons/close-w-20.png 2.25x, icons/close-w-24.png 2.5x, icons/close-w-30.png 3x, icons/close-w-30.png 3.5x"" draggable=""false"" b-vjg3tdneki>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "sidebar");
            __builder.AddAttribute(39, "b-vjg3tdneki");
            __builder.OpenComponent<BlazorElectronTemplate.Shared.NavMenu>(40);
            __builder.AddComponentReferenceCapture(41, (__value) => {
#nullable restore
#line 35 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                       navmenu = (BlazorElectronTemplate.Shared.NavMenu)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "main");
            __builder.AddAttribute(45, "b-vjg3tdneki");
            __builder.OpenElement(46, "ul");
            __builder.AddAttribute(47, "class", "nav nav-pills");
            __builder.AddAttribute(48, "b-vjg3tdneki");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "btn-group");
            __builder.AddAttribute(51, "role", "group");
            __builder.AddAttribute(52, "aria-label", "Basic mixed styles example");
            __builder.AddAttribute(53, "b-vjg3tdneki");
#nullable restore
#line 40 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                 foreach (var link in listnavlink)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "nav-link");
            __builder.AddAttribute(56, "href", 
#nullable restore
#line 42 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                     link.Href

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 42 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                                       NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(59, "span");
                __builder2.AddAttribute(60, "class", "oi" + " oi-" + (
#nullable restore
#line 43 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                            link.Icon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "aria-hidden", "true");
                __builder2.AddAttribute(62, "b-vjg3tdneki");
                __builder2.CloseElement();
                __builder2.AddContent(63, 
#nullable restore
#line 43 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                                                  link.Name

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "class", "btn btn-danger");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
                                                             ()=>DeleteObjectNavlink(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "b-vjg3tdneki");
            __builder.AddContent(69, "X");
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "content px-4");
            __builder.AddAttribute(73, "b-vjg3tdneki");
            __builder.AddContent(74, 
#nullable restore
#line 51 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\mag\Documents\BlazorElectronTemplate\BlazorElectronTemplate\Shared\MainLayout.razor"
      
    List<TabClass> listnavlink = new List<TabClass>();
    NavMenu navmenu;
    protected override async Task OnInitializedAsync()
    {
        maximized = false;
    }
    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        navmenu.SetListNavlink(listnavlink);
    }
    private bool maximized = false;
    private void CloseElectronApplication()
    {
        Electron.App.Quit();
    }
    private void RestoreElectronApplication()
    {
        var menuitem = new MenuItem { Role = MenuRole.unhide, Label = "Развернуть" };
        menuitem.Click += HideTrayIcon;
        Electron.Tray.Show(@"./StartMonitor/wwwroot/YourPNGandPath.png", menuitem);
        var mainWindows = Electron.WindowManager.BrowserWindows.First();
        mainWindows.Hide();
    }
    private void FullscreenApplication()
    {
        var mainWindows = Electron.WindowManager.BrowserWindows.First();
        mainWindows.SetFullScreen(true);
        maximized = true;
    }
    private void RestorescreenApplication()
    {
        var mainWindows = Electron.WindowManager.BrowserWindows.First();
        mainWindows.SetFullScreen(false);
        maximized = false;
    }
    private void HideTrayIcon()
    {
        Electron.Tray.Destroy();
        var mainWindows = Electron.WindowManager.BrowserWindows.First();
        mainWindows.Show();
    }
    private void DeleteObjectNavlink(TabClass tab)
    {
        listnavlink.Remove(tab);
        if (listnavlink.Count > 0)
        {
            NavigationManager.NavigateTo(listnavlink[listnavlink.Count-1].Href);
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
        navmenu.SetListNavlink(listnavlink);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
