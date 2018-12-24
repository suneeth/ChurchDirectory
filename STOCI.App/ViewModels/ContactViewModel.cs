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

            LaunchMapsCommand = new Command<Contact>((model) => LaunchMap(model));
            CallCommand = new Command<Contact>((model) => CallPhone(model));
            MessageCommand = new Command<Contact>((model) => SendMessage(model));
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

    }
}
