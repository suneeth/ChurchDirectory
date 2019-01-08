using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STOCI.App
{
    public partial class EditProfileView : ContentPage,IModalPage
    {
        public EditProfileView()
        {
            InitializeComponent();
        }

        public void Dismiss()
        {
            App.Nav.PopModalAsync();
        }
    }
}
