using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using STOCI.App;
using Xamarin.Forms;
using STOCI.App.iOS;

[assembly: ExportRenderer(typeof(Page), typeof(CustomPageRenderer))]
namespace STOCI.App.iOS
{
    public class CustomPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (Element is IModalPage modalPage)
            {
                NavigationController.TopViewController.NavigationItem.LeftBarButtonItem =
                    new UIBarButtonItem(title: "Cancel",
                        style: UIBarButtonItemStyle.Plain,
                        handler: (sender, args) => { modalPage.Dismiss(); });
            }
        }
    }
}
