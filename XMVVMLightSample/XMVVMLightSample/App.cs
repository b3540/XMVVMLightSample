using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XMVVMLightSample.View;
using XMVVMLightSample.ViewModel;

namespace XMVVMLightSample
{
    public class App : Application
    {
        public App()
        {
            ViewModelLocator.Setup();
            MainPage = ServiceLocator.Current.GetInstance<MainView>();
        }

        protected override void OnStart() { ; }

        protected override void OnSleep() { ; }

        protected override void OnResume() { ; }
    }
}
