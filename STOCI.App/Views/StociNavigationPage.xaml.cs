using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STOCI.App
{
    public partial class StociNavigationPage : NavigationPage
    {
        public StociNavigationPage()
        {
            InitializeComponent();
        }

        public StociNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}
