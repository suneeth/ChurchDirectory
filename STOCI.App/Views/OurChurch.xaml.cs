using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STOCI.App
{
    public partial class OurChurch : ContentPage,ITabPage
    {
        public OurChurch()
        {
            InitializeComponent();
        }

        public string TabIcon => "\uf51d";

        public string SelectedTabIcon => "\uf51d";
    }
}
