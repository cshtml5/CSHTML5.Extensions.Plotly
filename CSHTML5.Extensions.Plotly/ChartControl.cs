using CSHTML5;
using System;
using Windows.UI.Xaml.Controls;

namespace CSHTML5.Extensions.Plotly
{
    //------------------------------------------------------------------------
    // INTRODUCTION:
    //
    // This is an open-source extension for "C#/XAML for HTML5" that provides
    // chart controls based on the open-source "Plotly.js" library.
    //
    // "C#/XAML for HTML5" - also known as "CSHTML5" - is a Visual Studio tool that
    // enables developers to create cross-platform HTML5 applications using only C# and XAML.
    // It can be downloaded from: http://www.cshtml5.com
    //
    // To be able to compile this project using Visual Studio, you need to download and
    // install the latest version of "C#/XAML for HTML5", available from: http://www.cshtml5.com
    //
    //
    //
    // LICENSE:
    //
    // This project is licensed under The open-source MIT license:
    // https://opensource.org/licenses/MIT
    //
    // Copyright 2017 Userware / CSHTML5 (C#/XAML for HTML5)
    //
    //
    //
    // HOW IS IT IMPLEMENTED?
    //
    // It is implemented by having a C#-based wrapper around the JavaScript library "Plotly.js".
    // With such a "wrapper", it is possible to use the JavaScript library directly from C#,
    // as if it was a C# library.
    //
    // Documentation of this concept of "wrapper" can be found at:
    // http://cshtml5.com/links/how-to-create-extensions.aspx
    // and
    // http://cshtml5.com/links/how-to-call-javascript.aspx
    //
    //
    //
    // WHERE CAN I FIND THE DOCUMENTATION OF THE PLOTLY LIBRARY?
    //
    // Documentation of the JavaScript Plotly library can be found at:
    // - Plotly API Reference: https://plot.ly/javascript/reference/
    // - Plotly JS samples: https://plot.ly/javascript/#basic-charts 
    //------------------------------------------------------------------------


    public class ChartControl : Canvas
    {
        // Remember whether the JS library was loaded in order not to load it twice:
        static bool JSLibraryWasLoaded;

        public ChartControl()
        {
            this.Loaded += ChartControl_Loaded;

            // Set default values:
            this.Data = new Data();
            this.Layout = new Layout();
        }

        async void ChartControl_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Load the "Plotly" JavaScript library if it is not already loaded:
            if (!JSLibraryWasLoaded)
            {
                await Interop.LoadJavaScriptFile("ms-appx:///CSHTML5.Extensions.Plotly/JS/plotly-latest.min.js");
                JSLibraryWasLoaded = true;
            }

            // Get a reference to the HTML DOM representation of the control (must be in the Visual Tree):
            object div = Interop.GetDiv(this);

            // Make sure that the Div has an ID, because "Plotly" requires an ID:
            Interop.ExecuteJavaScript("if (!$0.id) { $0.id = $1 }", div, Guid.NewGuid().ToString());

            // Get the data, layout, and other JS objects:
            object jsData = this.Data.ToJavaScriptObject();
            object jsLayout = this.Layout.ToJavaScriptObject();

            // Render the control:
            Interop.ExecuteJavaScript(@"
                Plotly.newPlot($0.id, $1, $2);
                ", div, jsData, jsLayout);
        }

        public Data Data { get; set; }

        public Layout Layout { get; set; }
    }
}
