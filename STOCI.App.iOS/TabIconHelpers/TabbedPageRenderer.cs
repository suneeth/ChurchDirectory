using System;
using System.Collections.Generic;
using System.Linq;
using CoreGraphics;
using STOCI.App;
using STOCI.App.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MainPageView), typeof(TabbedPageRenderer))]
namespace STOCI.App.iOS
{
    public class TabbedPageRenderer : TabbedRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var renderers = this.ViewController.ChildViewControllers
                                           .OfType<IVisualElementRenderer>()
                                           .ToArray();

            List<ITabPage> pages =new List<ITabPage>() ;
            foreach(var renderer in renderers)
            {
                if(renderer is PageRenderer)
                {
                    pages.Add(renderer.Element as ITabPage);
                }
                else if(renderer is NavigationRenderer)
                {
                    var navigationpage = renderer.Element as NavigationPage;
                    pages.Add(navigationpage.CurrentPage as ITabPage);
                }
            }

            if (pages.Count != this.TabBar.Items.Length)
            {
                throw new Exception("Uh oh! Inconsistent number of pages and tabbar items!");
            }

            for (var i = 0; i < pages.Count; i++)
            {
                var tabItem = this.TabBar.Items[i];
                if (tabItem.Image == null)
                {
                    tabItem.Image = ImageHelper.ImageFromFont(pages[i].TabIcon, UIColor.Black, new CGSize(35, 20)); 
                    tabItem.SelectedImage = ImageHelper.ImageFromFont(pages[i].SelectedTabIcon, UIColor.Black, new CGSize(35, 20)); 
                }
            }
        }
    }
}
