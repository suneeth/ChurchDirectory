using System;
using Android.Widget;
using STOCI.App.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("STOCI.App")]
[assembly: ExportEffect(typeof(RemoveBorderEffect), "RemoveBorderEffect")]
namespace STOCI.App.Droid
{
    public class RemoveBorderEffect:PlatformEffect
    {
         


        protected override void OnAttached()
        {
            //var searchView = Control as SearchView;

            //int searchPlateId = searchView.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
            //Android.Views.View searchPlateView = searchView.FindViewById(searchPlateId);
            //searchPlateView.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

        protected override void OnDetached()
        {
        }
    }
}
