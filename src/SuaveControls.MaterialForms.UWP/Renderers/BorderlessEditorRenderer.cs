﻿using SuaveControls.MaterialForms;
using SuaveControls.MaterialForms.UWP.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(BorderlessEditor), typeof(BorderlessEditorRenderer))]

namespace SuaveControls.MaterialForms.UWP.Renderers
{
    public class BorderlessEditorRenderer : EditorRenderer
    {
        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Margin = new Windows.UI.Xaml.Thickness(0);
                Control.Padding = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
