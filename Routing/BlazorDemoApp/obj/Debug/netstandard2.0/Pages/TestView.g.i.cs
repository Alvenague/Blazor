#pragma checksum "D:\CoreApp\BlazorTestApp\TestApp\BlazorDemoApp\Pages\TestView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a334b126d505ebc93f316856fa9a43fdcf2ea378"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorDemoApp;
    using BlazorDemoApp.Shared;
    using Microsoft.AspNetCore.Blazor.Services;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/example/{Name}")]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/constrains/{Parameter1:int}")]
    public class TestView : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 21 "D:\CoreApp\BlazorTestApp\TestApp\BlazorDemoApp\Pages\TestView.cshtml"
            


    public string Name { get; set; }

    public int Parameter1 { get; set; }

    void ButtonClicked()
    {
        UriHelper.NavigateTo("example3");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
