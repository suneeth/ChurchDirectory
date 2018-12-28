using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using STOCI.App.DataService;
using STOCI.App;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmHelpers;
using Plugin.Messaging;
using Xamarin.Forms;

namespace STOCI.App
{
    public class DirectoryViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;

        public ICommand SearchCommand { get; private set; }
        public ICommand LaunchMapsCommand { get; private set; }
        public ICommand CallCommand { get; private set; }
        public ICommand MessageCommand { get; private set; }
        public ICommand ContactTappedCommand { get; private set; }

        public List<ObservableGroupCollection<string,Contact>> Contacts { get; set; }


        public DirectoryViewModel(IDataService dataService,INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            Contacts = new List<ObservableGroupCollection<string,Contact>>();
            GetAllContacts();
            SearchCommand = new Command(() => GetAllContacts());
            LaunchMapsCommand = new Command<Contact>((model) => LaunchMap(model));
            CallCommand = new Command<Contact>((model) => CallPhone(model));
            MessageCommand = new Command<Contact>((model) => SendMessage(model));

            ContactTappedCommand = new Command( OnContactTapped);
        }

        private void OnContactTapped(object contactTappedEventArgs)
        {
            var contact = ((contactTappedEventArgs as ItemTappedEventArgs)?.Item as Contact);

            _navigationService.NavigateToAsync(typeof(ContactViewModel), contact);

        }

      

        private void SendMessage(Contact model)
        {
            var smsSender = CrossMessaging.Current.SmsMessenger;
            if (smsSender.CanSendSms)
                smsSender.SendSms(model.PhoneNumber);
        }

        private void CallPhone(Contact model)
        {
            var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (PhoneCallTask.CanMakePhoneCall)
                PhoneCallTask.MakePhoneCall(model.PhoneNumber);
        }

        private void LaunchMap(Contact contact)
        {
            var request = "";
            switch (Device.RuntimePlatform)
            {
              case Device.iOS:
                    request = string.Format("http://maps.apple.com/maps?q={0}", contact.Address.Street.Replace(' ', '+'));
                    break;
                case Device.Android:
                    request = string.Format("geo:0,0?q={0}", contact.Address.Street);
                    break;

            }
            Device.OpenUri(new Uri(request));

        }

        private void GetAllContacts()
        {
            IsBusy = true;
            var contacts = _dataService.GetAllContacts();

            var groupedData = contacts.OrderBy(p => p.FirstName)
              .GroupBy(p => p.FirstName[0].ToString())
              .Select(p => new ObservableGroupCollection<string, Contact>(p)).ToList();

            Contacts=groupedData;

            IsBusy = false;
        }
    }

    public class ObservableGroupCollection<S, T> : ObservableRangeCollection<T>
    {
        private readonly S _key;
        public ObservableGroupCollection(IGrouping<S, T> group)
            : base(group)
        {
            _key = group.Key;
        }
        public S Key
        {
            get { return _key; }
        }
    }


}
