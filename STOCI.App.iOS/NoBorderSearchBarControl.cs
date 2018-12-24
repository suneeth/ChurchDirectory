using System;
using STOCI.App.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("STOCI.App")]
[assembly: ExportEffect(typeof(RemoveBorderEffect), "RemoveBorderEffect")]
namespace STOCI.App.iOS
{

    public class RemoveBorderEffect : PlatformEffect
    {
        UISearchBarStyle oldstyle;
        protected override void OnAttached()
        {
            var searchbar = Control as UISearchBar;
            if (searchbar != null)
            {
                oldstyle = searchbar.SearchBarStyle;
                searchbar.BarStyle = UIBarStyle.Default;
                searchbar.BackgroundImage = new UIImage();
                Foundation.NSString _searchField = new Foundation.NSString("searchField");
                var textFieldInsideSearchBar = (UITextField)searchbar.ValueForKey(_searchField);
                 textFieldInsideSearchBar.BackgroundColor = UIColor.FromRGB(220, 220, 220);

            }

        }

        protected override void OnDetached()
        {
            var searchbar = Control as UISearchBar;
            if(searchbar!=null)
            searchbar.SearchBarStyle = oldstyle;
        }
    }
}
