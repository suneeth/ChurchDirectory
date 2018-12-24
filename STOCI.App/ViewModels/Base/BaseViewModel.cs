using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace STOCI.App
{
    public class BaseViewModel:ViewModelBase
    {
        private bool _isBusy;


        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                RaisePropertyChanged(nameof(IsBusy));
            }
        }
        public BaseViewModel()
        {
        }

        public virtual Task InitializeAsync(object data)
        {
            return Task.FromResult(false);
        }
    }
}
