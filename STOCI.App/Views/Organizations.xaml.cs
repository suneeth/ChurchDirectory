using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STOCI.App
{
    public partial class Organizations : ContentPage,ITabPage
    {
        public Organizations()
        {
            InitializeComponent();
        }

        public string TabIcon => "\uf009";

        public string SelectedTabIcon => "\uf009";
    }
}
