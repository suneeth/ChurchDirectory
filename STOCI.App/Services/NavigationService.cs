﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace STOCI.App
{
    public class NavigationService : INavigationService
    {
        private readonly Dictionary<Type, Type> _mappings;

        protected Application CurrentApplication => Application.Current;

        public static StociNavigationPage StociNavigation;


        public NavigationService()
        {
            _mappings = new Dictionary<Type, Type>();

            CreatePageViewModelMappings();
        }

        public async Task ClearBackStackAsync()
        {
            await CurrentApplication.MainPage.Navigation.PopToRootAsync();

        }


        public async Task InitializeAsync()
        {
            //if (_authenticationService.IsUserAuthenticated())
            //{
            //    await NavigateToAsync<MainViewModel>();
            //}
            //else
            //{
              await NavigateToAsync<MainPageViewModel>();
            //}
        }

        public async Task NavigateBackAsync()
        {
            await CurrentApplication.MainPage.Navigation.PopAsync();
        }

        public async Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase => await InternalNavigateToAsync(typeof(TViewModel), null);

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return InternalNavigateToAsync(typeof(TViewModel), parameter);
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            return InternalNavigateToAsync(viewModelType, null);
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            return InternalNavigateToAsync(viewModelType, parameter);
        }

        public Task ShowModalAsync(Type viewModelType, object parameter) 
        {
            return InternalShowModalAsync(viewModelType, parameter);
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveLastFromBackStackAsync()
        {
            throw new NotImplementedException();
        }


        protected virtual async Task InternalShowModalAsync(Type viewModelType, object parameter)
        {
            var page = CreatePage(viewModelType, parameter);
             await App.Nav.PushModalAsync(new NavigationPage(page));
            await (page.BindingContext as BaseViewModel).InitializeAsync(parameter);

        }

        public async Task DismissModalAsync()
        {
            await App.Nav.PopModalAsync();
        }


        protected virtual async Task InternalNavigateToAsync(Type viewModelType, object parameter)
        {
            var page = CreatePage(viewModelType, parameter);
           

        
             App.Nav.PushAsync(page);

            await (page.BindingContext as BaseViewModel).InitializeAsync(parameter);
        }


        protected Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"No map for ${viewModelType} was found on navigation mappings");
            }

            return _mappings[viewModelType];
        }

        protected Page CreatePage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page");
            }

            Page page = Activator.CreateInstance(pageType) as Page;

            return page;
        }


        private void CreatePageViewModelMappings()
        {

            _mappings.Add(typeof(MainPageViewModel), typeof(MainPageView));
            _mappings.Add(typeof(DirectoryViewModel), typeof(DirectoryView));
            _mappings.Add(typeof(ContactViewModel), typeof(ContactView));
            _mappings.Add(typeof(MyProfileViewModel), typeof(MyProfileView));
            _mappings.Add(typeof(EditProfileViewModel), typeof(EditProfileView));

            //_mappings.Add(typeof(HomeViewModel), typeof(HomeView));
            //_mappings.Add(typeof(CheckoutViewModel), typeof(CheckoutView));
            //_mappings.Add(typeof(ContactViewModel), typeof(ContactView));
            //_mappings.Add(typeof(PieCatalogViewModel), typeof(PieCatalogView));
            //_mappings.Add(typeof(PieDetailViewModel), typeof(PieDetailView));
            //_mappings.Add(typeof(RegistrationViewModel), typeof(RegistrationView));
            //_mappings.Add(typeof(ShoppingCartViewModel), typeof(ShoppingCartView));
        }
    }
  
}
