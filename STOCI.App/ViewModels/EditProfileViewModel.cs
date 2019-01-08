using System;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace STOCI.App
{
    public class EditProfileViewModel : BaseViewModel
    {
        private Contact _selectedContact;

        private INavigationService _navigationService;



        public EditProfileViewModel()
        {
        }

        public Contact SelectedContact
        {
            get => _selectedContact;
            private set
            {
                _selectedContact = value; RaisePropertyChanged(() => SelectedContact);
            }
        }

        public override async Task InitializeAsync(object contact)
        {
            SelectedContact = (Contact)contact;
        }

        public EditProfileViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

    
    }
}
