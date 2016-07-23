/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:XMVVMLightSample"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using XMVVMLightSample.View;

namespace XMVVMLightSample.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator() { ; }

        public static void Setup()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();
            SimpleIoc.Default.Register<MainView>();
            SimpleIoc.Default.Register<SecondView>();
        }

        public static MainViewModel Main { get { return ServiceLocator.Current.GetInstance<MainViewModel>(); } }
        public static SecondViewModel Second { get { return ServiceLocator.Current.GetInstance<SecondViewModel>(); } }

        public static void Cleanup() { ; }
    }
}