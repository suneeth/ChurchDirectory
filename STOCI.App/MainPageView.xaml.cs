using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STOCI.App
{
    public partial class MainPageView : TabbedPage
    {
        public MainPageView()
        {
            InitializeComponent();
            //var page = new NavigationPage(new DirectoryView());
            //page.Title = "Directory";
            //Children.Add(new OurChurch());
            //Children.Add(page);

        }


        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            App.Nav = CurrentPage.Navigation;
        }
    }
}
