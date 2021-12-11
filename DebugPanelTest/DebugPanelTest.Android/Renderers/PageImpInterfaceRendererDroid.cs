using System;
using SlideOverKit;
using SlideOverKit.Droid;
using DebugPanelTest;
using DebugPanelTest.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: ExportRenderer (typeof (MenuContainerPage), typeof (PageImpInterfaceRendererDroid))]
namespace DebugPanelTest.Android
{
    // As your page cannot inherit from MenuContainerPage,
    // You must create a renderer page, copy these codes and rename.
    public class PageImpInterfaceRendererDroid : PageRenderer, ISlideOverKitPageRendererDroid
    {
        public Action<ElementChangedEventArgs<Page>> OnElementChangedEvent { get; set; }

        public Action<bool, int, int, int, int> OnLayoutEvent { get; set; }

        public Action<int, int, int, int> OnSizeChangedEvent { get; set; }

        public PageImpInterfaceRendererDroid (Context context) : base (context)
        {
            new SlideOverKitDroidHandler ().Init (this, context);
        }

        protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged (e);
            OnElementChangedEvent?.Invoke (e);
        }

        protected override void OnLayout (bool changed, int l, int t, int r, int b)
        {
            base.OnLayout (changed, l, t, r, b);
            OnLayoutEvent?.Invoke (changed, l, t, r, b);
        }

        protected override void OnSizeChanged (int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged (w, h, oldw, oldh);
            OnSizeChangedEvent?.Invoke (w, h, oldw, oldh);
        }
    }
}

