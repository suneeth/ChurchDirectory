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
        }


        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            App.Nav = CurrentPage.Navigation;
        }
    }
}
