using System;
using System.Globalization;
using System.Reflection;
using Autofac;
using Xamarin.Forms;

namespace STOCI.App
{

    public class ViewModelLocator
    {
        public static readonly BindableProperty AutoWireViewModelProperty =
          BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool),
              typeof(ViewModelLocator), default(bool),
              propertyChanged: OnAutoWireViewModelChanged);

          private static ILifetimeScope _rootScope;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            var assemblies = new[] { Assembly.GetExecutingAssembly() };

            builder.RegisterAssemblyTypes(assemblies)
            .SingleInstance().AsImplementedInterfaces().AsSelf();
            _rootScope = builder.Build();
        }


        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(AutoWireViewModelProperty, value);
        }

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is Element view))
            {
                return;
            }

            var viewType = view.GetType();
            if (viewType.FullName != null)
            {
                var viewName = viewType.FullName.Replace(".Views.", ".ViewModels.");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}Model, {1}", viewName, viewAssemblyName);

                var viewModelType = Type.GetType(viewModelName);
                if (viewModelType == null)
                {
                    return;
                }
                var viewModel = _rootScope.Resolve(viewModelType);
                view.BindingContext = viewModel;
            }
        }

        public static T Resolve<T>()
        {
            return _rootScope.Resolve<T>();
        }
    }

    //public class ViewModelLocator
    //{
    //    private ILifetimeScope _rootScope;

    //    public ViewModelLocator()
    //    {
    //        var builder = new ContainerBuilder();
    //        var assemblies = new[] { Assembly.GetExecutingAssembly() };

    //        builder.RegisterAssemblyTypes(assemblies)
    //               .SingleInstance().AsImplementedInterfaces().AsSelf();
    //        _rootScope = builder.Build();
    //    }

    //    public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

    //    public DirectoryViewModel DirectoryVM
    //    {
    //        get
    //        {
    //            return _rootScope.Resolve<DirectoryViewModel>();
    //        }
    //    }
    //}
}
