using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STOCI.App
{
    public partial class MyProfile : ContentPage,ITabPage
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        public string TabIcon => "\uf406";

        public string SelectedTabIcon => "\uf406";
    }
}
