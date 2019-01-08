using System;
using Android.App;
using Android.Content;
using Android.Support.Design.Widget;
using Android.Widget;
using STOCI.App.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(ContentPage), typeof(IconPageRenderer))]
namespace STOCI.App.Droid
{
    public class IconPageRenderer : PageRenderer
    {
        private Context _context;
        public IconPageRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnAttachedToWindow()
        {

            //var tabs = this.FindViewById<TabLayout>(Resource.Id.sliding_tabs);

            base.OnAttachedToWindow();

            var tabPage = this.Element as ITabPage;

            var actionBar = ((Activity)_context)?.ActionBar;
            if (actionBar != null && !string.IsNullOrEmpty(tabPage?.TabIcon))
            {
                actionBar.SetIcon(new FontDrawable(this.Context, tabPage.TabIcon, Color.White.ToAndroid(), 32));
            }
        }

    }
    
}
