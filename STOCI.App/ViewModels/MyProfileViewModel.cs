using System;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace STOCI.App
{
    public class MyProfileViewModel : BaseViewModel
    {
        private Contact _selectedContact;

        private INavigationService _navigationService;

        public ICommand EditCommand { get; private set; }


        public MyProfileViewModel()
        {
        }

        public Contact SelectedContact 
        { 
            get => new Contact 
            { 
                 Address=new Address
                 {
                      City="Auburn Hills",
                      State="MI",
                      Street="201 N Squirrel Rd",
                      Zip="48326" 
                 },
                  FamilyMembers="Asha Varghese,George Erakkath",
                  FirstName="Suneeth",
                  LastName="Varghese",
                  PhoneNumber="732-425-5608"
            };
            private set  
            { 
            _selectedContact = value; RaisePropertyChanged(() => SelectedContact);} 
            }

        //public override async Task InitializeAsync(object contact)
        //{
        //    SelectedContact = (Contact)contact;
        //}

        public MyProfileViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            EditCommand = new Command(() => EditUser());
        }

        private void Cancel()
        {
            _navigationService.DismissModalAsync();
        }

        private void EditUser()
        {
            _navigationService.ShowModalAsync<EditProfileViewModel>(_selectedContact);
        }

    }
}
