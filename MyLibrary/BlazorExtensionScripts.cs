﻿using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;

namespace MyLibrary
{
    public class BlazorExtensionScripts : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "script"); 
            builder.AddContent(1, "Blazor.registerFunction('Alert', (message) => { alert(message); });");
            builder.CloseElement(); 
        }

        public static void Alert(string msg)
        {
            RegisteredFunction.Invoke<object>("Alert", msg);
        }
    }
}
