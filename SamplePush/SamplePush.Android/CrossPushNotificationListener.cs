using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using PushNotification.Plugin;
using PushNotification.Plugin.Abstractions;
using System.Diagnostics;

namespace SamplePush.Droid
{
   public class CrossPushNotificationListener : IPushNotificationListener
    {
        public CrossPushNotificationListener()
        {
        }
        public void OnError(string message, DeviceType deviceType)
        {
            
        }

        public void OnMessage(global::Newtonsoft.Json.Linq.JObject values, DeviceType deviceType)
        {
            Debug.WriteLine(string.Format("Push Notification -recieved", values));
        }

        public void OnRegistered(string token, DeviceType deviceType)
        {
            Debug.WriteLine(string.Format("Push Notification - Device Registered - Token : {0}", token));
        }

        public void OnUnregistered(DeviceType deviceType)
        {
            
        }

        public bool ShouldShowNotification()
        {
            return true;
        }
    }
}