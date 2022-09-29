using DesktopNotifications;
using DesktopNotifications.Windows;

using System.Runtime.InteropServices;
using System;

namespace WPR.Common
{
    public static class NativeUI
    {
        public static INotificationManager NotificationManager { get; set; }

        static NativeUI()
        {
            // mono-platform (only single Windows platform) case
            
            NotificationManager = new WindowsNotificationManager();
            
            NotificationManager.Initialize();
        }
    }
}
