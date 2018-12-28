using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STOCI.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DirectoryView : ContentPage,ITabPage
    {
        public DirectoryView()
        {
            InitializeComponent();
        }

        public string TabIcon => "\uf0c0";

        public string SelectedTabIcon => "\uf0c0";
    }
}
