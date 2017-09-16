using PushNotification.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SamplePush
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SamplePush.MainPage();
        }

        protected override void OnStart()
        {
            CrossPushNotification.Current.Register();
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
