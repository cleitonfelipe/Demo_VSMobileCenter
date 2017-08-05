using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace Demo_VSMobileCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Demo_VSMobileCenter.MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("android=450086db-1d00-4153-94b3-1e30993e70fd;",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
