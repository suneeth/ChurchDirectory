using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace STOCI.App
{
    public partial class App : Application
    {
        public static INavigation Nav { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeApp();

            Application.Current.MainPage = new MainPageView();


            var myNavigationPage = new NavigationPage(new DirectoryView());
            Nav = myNavigationPage.Navigation;


            //InitializeNavigation();
        }

        private async Task InitializeNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }

        private void InitializeApp()
        {
            ViewModelLocator.RegisterDependencies();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
