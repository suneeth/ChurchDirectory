using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace STOCI.App
{
 public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task ShowModalAsync(Type viewModelType,object parameter);

        Task NavigateToAsync(Type viewModelType);

        Task DismissModalAsync();

        Task ClearBackStackAsync();

        Task NavigateToAsync(Type viewModelType, object parameter);

        Task NavigateBackAsync();

        Task RemoveLastFromBackStackAsync();

        Task PopToRootAsync();
    }
}
