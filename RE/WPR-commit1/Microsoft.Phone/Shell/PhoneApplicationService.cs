using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Shell
{
    public class PhoneApplicationService
    {
        static PhoneApplicationService()
        {
            Current = new PhoneApplicationService();
        }

        public PhoneApplicationService()
        {
            UserIdleDetectionMode = IdleDetectionMode.Disabled;
            ApplicationIdleDetectionMode = IdleDetectionMode.Disabled;
        }

        public void HandleOneFrameRunDone(bool anew)
        {
            Activated?.Invoke(this, new ActivatedEventArgs(!anew));
        }

        public void HandleApplicationExit()
        {
            try
            {
                Deactivated?.Invoke(this, new DeactivatedEventArgs());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[ex] App deactive phase error: \n{ex.Message}");
            }

            try
            {
                Closing?.Invoke(this, new ClosingEventArgs());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[ex] App close phase error: \n{ex.Message}");
            }

            // Recycle
            Current = new PhoneApplicationService();
        }

        public event EventHandler<ActivatedEventArgs>? Activated;
        public event EventHandler<DeactivatedEventArgs>? Deactivated;
        public event EventHandler<LaunchingEventArgs>? Launching;
        public event EventHandler<ClosingEventArgs>? Closing;

        public StartupMode StartupMode { get => StartupMode.Launch; }

        public static PhoneApplicationService? Current { get; private set; }

        public IDictionary<string, object>? State { get; private set; }

        public IdleDetectionMode UserIdleDetectionMode { get; set; }
        public IdleDetectionMode ApplicationIdleDetectionMode { get; set; }
    }
}
