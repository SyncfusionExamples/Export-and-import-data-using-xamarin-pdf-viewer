﻿#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Android.Content;
using Android.Graphics;
using SampleBrowser.SfPdfViewer;
using SampleBrowser.SfPdfViewer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace SampleBrowser.SfPdfViewer.Droid
{
    class CustomLabelRenderer : LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {

                if (Control != null)
                {
                    Control.SetBackgroundColor(Android.Graphics.Color.Rgb(0, 119, 255));
                    Control.SetTextColor(Android.Graphics.Color.White);
                }
            }
        }
    }
}
