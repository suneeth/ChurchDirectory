using System;
using System.Threading.Tasks;
using System.Windows.Input;
using STOCI.App;
using GalaSoft.MvvmLight;
using Plugin.Messaging;
using Xamarin.Forms;

namespace STOCI.App
{
    public class ContactViewModel:BaseViewModel
    {
        private string _address;

        private Contact _selectedcontact { get; set; }
        public ICommand LaunchMapsCommand { get; private set; }
        public ICommand CallCommand { get; private set; }
        public ICommand MessageCommand { get; private set; }


        public Contact SelectedContact
        {
            get => _selectedcontact;
            set
            {
                _selectedcontact = value;
                RaisePropertyChanged(nameof(SelectedContact));
            }
        }

     


        public override async Task InitializeAsync(object contact)
        {
            SelectedContact = (Contact)contact;
        }

        public ContactViewModel()
        {

            LaunchMapsCommand = new Command(() => LaunchMap());
            CallCommand = new Command(() => CallPhone());
            MessageCommand = new Command(() => SendMessage());
        }

        private void SendMessage()
        {
            var smsSender = CrossMessaging.Current.SmsMessenger;
            if (smsSender.CanSendSms)
                smsSender.SendSms(_selectedcontact.PhoneNumber);
        }

        private void CallPhone()
        {
            var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (PhoneCallTask.CanMakePhoneCall)
                PhoneCallTask.MakePhoneCall(_selectedcontact.PhoneNumber);
        }

        private void LaunchMap()
        {
            var contact = _selectedcontact;
            var request = "";
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    request = string.Format("http://maps.apple.com/maps?q={0}", contact.Address.ToString().Replace(' ', '+'));
                    break;
                case Device.Android:
                    request = string.Format("geo:0,0?q={0}", contact.Address.ToString());
                    break;

            }
            Device.OpenUri(new Uri(request));

        }

    }
}
